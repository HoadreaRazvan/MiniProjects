using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static TaskManagerWinApiClass.WinApiClass;

namespace TaskManagerWinApiClass;

public partial class MainWindow : Window
{
    private DispatcherTimer processTimer;

    public MainWindow()
    {
        InitializeComponent();
        StartTimer();
    }

    private void StartTimer()
    {
        processTimer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        processTimer.Tick += (s, e) => LoadProcesses();
        processTimer.Start();
    }

    private void LoadProcesses()
    {
        ProcessInfo selectedProcess = dataGrid.SelectedItem as ProcessInfo;

        DataGridColumn sortedColumn = dataGrid.Items.SortDescriptions.Count > 0
            ? dataGrid.Columns.FirstOrDefault(c => c.SortDirection != null)
            : null;
        ListSortDirection? sortDirection = sortedColumn?.SortDirection;

        const uint TH32CS_SNAPPROCESS = 0x00000002;
        uint processId = 0;

        IntPtr snapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, processId);
        if (snapshot == IntPtr.Zero)
            return;

        List<ProcessInfo> processes = new List<ProcessInfo>();

        PROCESSENTRY32 processEntry = new PROCESSENTRY32();
        processEntry.dwSize = (uint)Marshal.SizeOf(typeof(PROCESSENTRY32));

        if (Process32First(snapshot, ref processEntry))
        {
            do
            {
                processes.Add(new ProcessInfo
                {
                    ProcessID = processEntry.th32ProcessID,
                    ExecutableName = (processEntry.szExeFile).TrimEnd('\0')
                });
            } while (Process32Next(snapshot, ref processEntry));
        }

        this.dataGrid.ItemsSource = processes;

        if (sortedColumn != null && sortDirection.HasValue)
        {
            dataGrid.Items.SortDescriptions.Clear();
            dataGrid.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(
                sortedColumn.SortMemberPath, sortDirection.Value));
            sortedColumn.SortDirection = sortDirection;
        }

        if (selectedProcess != null)
        {
            dataGrid.SelectedItem = processes.FirstOrDefault(p => p.ProcessID == selectedProcess.ProcessID);
        }
    }

    private void CloseProcess_Click(object sender, RoutedEventArgs e)
    {
        if (dataGrid.SelectedItem is ProcessInfo selectedProcess)
        {
            try
            {
                const uint PROCESS_TERMINATE = 0x0001;
                IntPtr hProcess = WinApiClass.OpenProcess((int)PROCESS_TERMINATE, false, (int)selectedProcess.ProcessID);

                if (hProcess == IntPtr.Zero)
                {
                    MessageBox.Show($"Nu s-a putut obtine handle-ul pentru procesul {selectedProcess.ExecutableName}.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                bool result = WinApiClass.TerminateProcess(hProcess, 0);

                if (result)
                {
                    MessageBox.Show($"Procesul {selectedProcess.ExecutableName} a fost inchis.", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
                    LoadProcesses();
                }
                else
                {
                    MessageBox.Show($"Esec la terminarea procesului {selectedProcess.ExecutableName}.", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la inchiderea procesului: {ex.Message}", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        else
        {
            MessageBox.Show("Selecteaza un proces din lista!", "Atentie", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}

public class ProcessInfo
{
    public uint ProcessID { get; set; }
    public string ExecutableName { get; set; }
}
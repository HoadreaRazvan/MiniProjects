using Microsoft.Win32;
using System.IO;
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
using static OpenPaintWinApiClass.WinApiClass;

namespace OpenPaintWinApiClass;

public partial class MainWindow : Window
{
    public PROCESS_INFORMATION procInfo;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnNotepad_Click(object sender, RoutedEventArgs e)
    {
        SECURITY_ATTRIBUTES procSec = new SECURITY_ATTRIBUTES();
        SECURITY_ATTRIBUTES threadSec = new SECURITY_ATTRIBUTES();
        STARTUPINFO startInfo = new STARTUPINFO();
        PROCESS_INFORMATION procInfo;

        string applicationPath = @"C:\Windows\notepad.exe";
        string filePath = Directory.GetCurrentDirectory() + @"\Files\test.txt";

        string commandLine = $"{applicationPath} {filePath}";

        bool result = WinApiClass.CreateProcess(
            applicationPath,
            commandLine,
            ref procSec,
            ref threadSec,
            false,
            0,
            IntPtr.Zero,
            null,
            ref startInfo,
            out procInfo
        );
    }

    private void BtnPaint_Click(object sender, RoutedEventArgs e)
    {
        SECURITY_ATTRIBUTES procSec = new SECURITY_ATTRIBUTES();
        SECURITY_ATTRIBUTES threadSec = new SECURITY_ATTRIBUTES();
        STARTUPINFO startInfo = new STARTUPINFO();
        PROCESS_INFORMATION procInfo;

        startInfo.cb = Marshal.SizeOf(typeof(STARTUPINFO));

        string paintPath = @"C:\Users\hoadr\AppData\Local\Microsoft\WindowsApps\mspaint.exe";

        bool result = CreateProcess(
            paintPath,
            null,
            ref procSec,
            ref threadSec,
            false,
            0,
            IntPtr.Zero,
            null,
            ref startInfo,
            out procInfo
        );

    }

    private void BtnBrowseNotepad_Click(object sender, RoutedEventArgs e)
    {
        StackPanel stackPanel = BtnBrowseNotepad.Content as StackPanel;
        TextBlock textBlock = stackPanel.Children[1] as TextBlock;

        if (textBlock.Text.Equals("Browse Files") == true)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != true) return;
            textBlock.Text = "Close File";

            string filePath = ofd.FileName;
            SECURITY_ATTRIBUTES procSec = new SECURITY_ATTRIBUTES();
            SECURITY_ATTRIBUTES threadSec = new SECURITY_ATTRIBUTES();
            STARTUPINFO startInfo = new STARTUPINFO();
            this.procInfo = new PROCESS_INFORMATION();

            string applicationPath = @"C:\Windows\notepad.exe";

            string commandLine = $"{applicationPath} {filePath}";

            bool result = WinApiClass.CreateProcess(
                applicationPath,
                commandLine,
                ref procSec,
                ref threadSec,
                false,
                (uint)WinApiClass.ThreadPriority.THREAD_PRIORITY_NORMAL,
                IntPtr.Zero,
                null,
                ref startInfo,
                out procInfo
            );
        }
        else
        {
            textBlock.Text = "Browse Files";
            WinApiClass.TerminateProcess(procInfo.hProcess, (uint)procInfo.dwProcessId);
        }
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }

    private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
        {
            this.DragMove();
        }
    }
}
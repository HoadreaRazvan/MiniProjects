using Microsoft.Win32;
using System.IO;
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

namespace OpenFileWinApiClass;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void BtnSearch_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        if (ofd.ShowDialog() != true) return;

        string filePath = ofd.FileName;

        IntPtr fHandler = WinApiClass.CreateFile(
            filePath,
            WinApiClass.FileAccess.GenericRead,
            WinApiClass.FileShare.None,
            IntPtr.Zero,
            WinApiClass.FileMode.OPEN_EXISTING,
            WinApiClass.FileAttributes.Normal,
            IntPtr.Zero
        );

        if (fHandler == IntPtr.Zero)
        {
            MessageBox.Show("Eroare la deschiderea fisierului");
            LblStatus.Content = "Eroare la deschiderea fisierului!";
            LblStatus.Foreground = System.Windows.Media.Brushes.Red;
            return;
        }
        else
        {
            LblStatus.Content = "Fisier deschis cu succes!";
            LblStatus.Foreground = System.Windows.Media.Brushes.Green;
        }

        FileInfo fileInfo = new FileInfo(filePath);
        long size = fileInfo.Length;
        byte[] buffer = new byte[size];
        uint bytesRead;

        bool success = WinApiClass.ReadFile(
            fHandler,
            buffer,
            (uint)buffer.Length,
            out bytesRead,
            IntPtr.Zero
        );

        string fileContent = Encoding.ASCII.GetString(buffer);

        RtbText.Document.Blocks.Clear();
        RtbText.Document.Blocks.Add(new Paragraph(new Run(fileContent)));
    }
}
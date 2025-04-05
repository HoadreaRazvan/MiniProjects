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

namespace ThreadPriorityWinApiClass;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private IntPtr threadHandle1 = IntPtr.Zero, threadHandle2 = IntPtr.Zero, threadHandle3 = IntPtr.Zero;
    private uint threadId1, threadId2, threadId3;

    private DateTime? stopTime1, stopTime2, stopTime3;

    private void BtnProgressBar1_Click(object sender, RoutedEventArgs e)
    {
        if (BtnProgressBar1.Content.Equals("Resume"))
        {
            BtnProgressBar1.Content = "Suspend";

            if (threadHandle1 == IntPtr.Zero)
            {
                IntPtr lpParam = (IntPtr)GCHandle.Alloc(ProgressBar1);

                threadHandle1 = (nint)WinApiClass.CreateThread(
                    IntPtr.Zero,
                    0,
                    new WinApiClass.LPTHREAD_START_ROUTINE(ThreadFunction),
                    lpParam,
                    WinApiClass.ThreadState.CREATE_SUSPENDED,
                    out threadId1
                );

                WinApiClass.ResumeThread(threadHandle1);
            }
            else
            {
                WinApiClass.ResumeThread(threadHandle1);
            }
        }
        else if (BtnProgressBar1.Content.Equals("Suspend"))
        {
            BtnProgressBar1.Content = "Resume";
            stopTime1 = DateTime.Now;
            WinApiClass.SuspendThread(threadHandle1);
        }
    }

    private void BtnProgressBar2_Click(object sender, RoutedEventArgs e)
    {
        if (BtnProgressBar2.Content.Equals("Resume"))
        {
            BtnProgressBar2.Content = "Suspend";

            if (threadHandle2 == IntPtr.Zero)
            {
                IntPtr lpParam = (IntPtr)GCHandle.Alloc(ProgressBar2);

                threadHandle2 = (nint)WinApiClass.CreateThread(
                    IntPtr.Zero,
                    0,
                    new WinApiClass.LPTHREAD_START_ROUTINE(ThreadFunction),
                    lpParam,
                    WinApiClass.ThreadState.CREATE_SUSPENDED,
                    out threadId2
                );

                WinApiClass.ResumeThread(threadHandle2);
            }
            else
            {
                WinApiClass.ResumeThread(threadHandle2);
            }
        }
        else if (BtnProgressBar2.Content.Equals("Suspend"))
        {
            BtnProgressBar2.Content = "Resume";
            stopTime2 = DateTime.Now;
            WinApiClass.SuspendThread(threadHandle2);
        }
    }

    private void BtnProgressBar3_Click(object sender, RoutedEventArgs e)
    {
        if (BtnProgressBar3.Content.Equals("Resume"))
        {
            BtnProgressBar3.Content = "Suspend";

            if (threadHandle3 == IntPtr.Zero)
            {
                IntPtr lpParam = (IntPtr)GCHandle.Alloc(ProgressBar3);

                threadHandle3 = (nint)WinApiClass.CreateThread(
                    IntPtr.Zero,
                    0,
                    new WinApiClass.LPTHREAD_START_ROUTINE(ThreadFunction),
                    lpParam,
                    WinApiClass.ThreadState.CREATE_SUSPENDED,
                    out threadId3
                );

                WinApiClass.ResumeThread(threadHandle3);
            }
            else
            {
                WinApiClass.ResumeThread(threadHandle3);
            }
        }
        else if (BtnProgressBar3.Content.Equals("Suspend"))
        {
            BtnProgressBar3.Content = "Resume";
            stopTime3 = DateTime.Now;
            WinApiClass.SuspendThread(threadHandle3);
        }
    }

    private uint ThreadFunction(IntPtr lpParam)
    {
        ProgressBar progressBar = (ProgressBar)((GCHandle)lpParam).Target;

        while (true)
        {
            try
            {
                Dispatcher.Invoke(() =>
                {
                    if (progressBar.Value < progressBar.Maximum)
                    {
                        progressBar.Value += 0.1;
                    }
                    else
                    {
                        progressBar.Value = 0;
                    }
                });
            }
            catch (Exception e) { }
        }
        return 0;
    }

    private void PriorityComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (PriorityComboBox1.SelectedItem is ComboBoxItem selectedItem)
        {
            SetThreadPriority(threadHandle1, selectedItem.Content.ToString());
        }
    }

    private void PriorityComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (PriorityComboBox2.SelectedItem is ComboBoxItem selectedItem)
        {
            SetThreadPriority(threadHandle2, selectedItem.Content.ToString());
        }
    }

    private void PriorityComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (PriorityComboBox3.SelectedItem is ComboBoxItem selectedItem)
        {
            SetThreadPriority(threadHandle3, selectedItem.Content.ToString());
        }
    }


    private void SetThreadPriority(IntPtr threadHandle, string priority)
    {
        if (threadHandle == IntPtr.Zero)
            return;

        if (priority.Equals("Idle"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_IDLE);
        else
            if (priority.Equals("Below Normal"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_BELOW_NORMAL);
        else
            if (priority.Equals("Normal"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_NORMAL);
        else
            if (priority.Equals("Above Normal"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_ABOVE_NORMAL);
        else
            if (priority.Equals("High"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_HIGHEST);
        else
            if (priority.Equals("Real Time"))
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_TIME_CRITICAL);
        else
            WinApiClass.SetThreadPriority(threadHandle, WinApiClass.ThreadPriority.THREAD_PRIORITY_NORMAL);
    }


    private void BtnTime_Click(object sender, RoutedEventArgs e)
    {
        IntPtr threadHandle = IntPtr.Zero;
        DateTime? stopTime = null;

        if (sender == BtnTime1)
        {
            threadHandle = threadHandle1;
            stopTime = stopTime1;
        }
        else if (sender == BtnTime2)
        {
            threadHandle = threadHandle2;
            stopTime = stopTime2;
        }
        else if (sender == BtnTime3)
        {
            threadHandle = threadHandle3;
            stopTime = stopTime3;
        }

        if (threadHandle != IntPtr.Zero)
        {
            WinApiClass.FILETIME creationTime, exitTime, kernelTime, userTime;
            if (WinApiClass.GetThreadTimes(threadHandle, out creationTime, out exitTime, out kernelTime, out userTime))
            {
                long kernelTicks = ((long)kernelTime.DateTimeHigh << 32) + kernelTime.DateTimeLow;
                long userTicks = ((long)userTime.DateTimeHigh << 32) + userTime.DateTimeLow;

                double kernelSeconds = kernelTicks / 10_000_000.0;
                double userSeconds = userTicks / 10_000_000.0;

                WinApiClass.SYSTEMTIME stCreationTime;
                WinApiClass.FileTimeToSystemTime(ref creationTime, out stCreationTime);

                string stopTimeText = stopTime.HasValue ? $"{stopTime.Value.Hour}:{stopTime.Value.Minute}:{stopTime.Value.Second}" : "Thread activ";

                string timeInfo = $"Kernel Mode Time: {kernelSeconds:F2} seconds\n" +
                                  $"User Mode Time: {userSeconds:F2} seconds\n" +
                                  $"Start Time: {stCreationTime.Hour}:{stCreationTime.Minute}:{stCreationTime.Second}\n" +
                                  $"Stop Time: {stopTimeText}";

                TimeLabel.Text = timeInfo;
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ThreadSynchronization
{
    public class Synchronization
    {
        private Counter counter = new Counter();
        private IntPtr threadHandle1 = IntPtr.Zero;
        private IntPtr threadHandle2 = IntPtr.Zero;
        private uint threadId1;
        private uint threadId2;
        private static WinApiClass.CRITICAL_SECTION criticalSection;

        private static IntPtr eventThread1;
        private static IntPtr eventThread2;

        public Synchronization()
        {
            Console.WriteLine("Start: " + counter.Value);

            WinApiClass.InitializeCriticalSection(out criticalSection);

            eventThread1 = WinApiClass.CreateEvent(IntPtr.Zero, false, true, null);  
            eventThread2 = WinApiClass.CreateEvent(IntPtr.Zero, false, false, null);  

            GCHandle gch = GCHandle.Alloc(counter);

            threadHandle1 = (nint)WinApiClass.CreateThread(
                IntPtr.Zero,
                0,
                new WinApiClass.LPTHREAD_START_ROUTINE(Thread1Function),
                (IntPtr)gch,
                0,
                out threadId1);

            threadHandle2 = (nint)WinApiClass.CreateThread(
                IntPtr.Zero,
                0,
                new WinApiClass.LPTHREAD_START_ROUTINE(Thread2Function),
                (IntPtr)gch,
                0,
                out threadId2);

            WinApiClass.WaitForSingleObject(threadHandle1, WinApiClass.INFINITE);
            WinApiClass.WaitForSingleObject(threadHandle2, WinApiClass.INFINITE);

            gch.Free();
            WinApiClass.DeleteCriticalSection(ref criticalSection);
            Console.WriteLine("Final: " + counter.Value);
        }

        private static uint Thread1Function(IntPtr lpParam)
        {
            GCHandle gch = (GCHandle)lpParam;
            Counter sharedCounter = (Counter)gch.Target;

            for (int i = 0; i < 5; i++)
            {
                WinApiClass.WaitForSingleObject(eventThread1, WinApiClass.INFINITE);

                WinApiClass.EnterCriticalSection(ref criticalSection);
                sharedCounter.Value++;
                Console.WriteLine("Thread 1: " + sharedCounter.Value);
                WinApiClass.LeaveCriticalSection(ref criticalSection);

                WinApiClass.SetEvent(eventThread2);
            }

            return 0;
        }

        private static uint Thread2Function(IntPtr lpParam)
        {
            GCHandle gch = (GCHandle)lpParam;
            Counter sharedCounter = (Counter)gch.Target;

            for (int i = 0; i < 5; i++)
            {
                WinApiClass.WaitForSingleObject(eventThread2, WinApiClass.INFINITE);

                WinApiClass.EnterCriticalSection(ref criticalSection);
                sharedCounter.Value++;
                Console.WriteLine("Thread 2: " + sharedCounter.Value);
                WinApiClass.LeaveCriticalSection(ref criticalSection);

                WinApiClass.SetEvent(eventThread1); 
            }

            return 0;
        }

        public class Counter
        {
            public int Value = 0;
        }
    }
}

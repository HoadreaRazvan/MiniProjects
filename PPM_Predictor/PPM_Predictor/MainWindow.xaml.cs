using Markov;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PPM_Predictor
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<FileResultViewModel> Files { get; set; } = new();

        private FileResultViewModel? _selectedFile;
        public FileResultViewModel? SelectedFile
        {
            get => _selectedFile;
            set { _selectedFile = value; OnPropertyChanged(nameof(SelectedFile)); }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            this.MouseLeftButtonDown += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };
        }

        private void AddFiles_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Trace files (*.tra)|*.tra|All files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == true)
            {
                Files.Clear();
                SelectedFile = null;

                foreach (var f in dialog.FileNames)
                {
                    Files.Add(new FileResultViewModel
                    {
                        FileName = System.IO.Path.GetFileName(f)
                    });
                }
            }
        }


        private void Run_Click(object sender, RoutedEventArgs e)
        {
            foreach (var file in Files)
            {
                string fullPath = AppDomain.CurrentDomain.BaseDirectory + @"Benchmark\" + file.FileName;

                var markov = new MarkovPPM(fullPath, HRg, PredictionBits, IsFullPPM);

                file.CorrectPrediction = markov.CorrectPrediction;
                file.IncorrectPrediction = markov.IncorrectPrediction;
                file.BranchesNumber = markov.BranchesNumber;
                file.Accuracy = markov.Accuracy;
                file.Dimness = markov.Dimness;

                file.Branches.Clear();

                foreach (var kvp in markov.BranchInfo)
                {
                    var b = kvp.Value;

                    file.Branches.Add(new BranchInfoViewModel
                    {
                        Id = kvp.Key,
                        TotalAccesses = b.TotalAccesses,
                        PercentageAccesses = b.PercentageAccesses,
                        CorrectPredictions = b.CorrectPredictions,
                        IncorrectPredictions = b.IncorrectPredictions,
                        Accuracy = b.Accuracy,
                        Dimness = b.Dimness
                    });
                }
            }

            OnPropertyChanged(nameof(Files));
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FileCard_Click(object sender, MouseButtonEventArgs e)
        {
            if (sender is Border border && border.Tag != null)
            {
                SelectedFile = border.Tag as FileResultViewModel;

            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string prop)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));


        private int _hrg = 3;
        public int HRg
        {
            get => _hrg;
            set
            {
                if (_hrg != value)
                {
                    _hrg = value;
                    OnPropertyChanged(nameof(HRg));
                }
            }
        }

        private int _predictionBits = 50;
        public int PredictionBits
        {
            get => _predictionBits;
            set
            {
                if (_predictionBits != value)
                {
                    _predictionBits = value;
                    OnPropertyChanged(nameof(PredictionBits));
                }
            }
        }

        private bool _isFullPPM = false;
        public bool IsFullPPM
        {
            get => _isFullPPM;
            set
            {
                if (_isFullPPM != value)
                {
                    _isFullPPM = value;
                    OnPropertyChanged(nameof(IsFullPPM));
                }
            }
        }
        public class FileResultViewModel : INotifyPropertyChanged
        {
            public string FileName { get; set; } = string.Empty;

            private int _correctPrediction;
            private int _incorrectPrediction;
            private int _branchesNumber;
            private double _accuracy;
            private double _dimness;

            public int CorrectPrediction
            {
                get => _correctPrediction;
                set { _correctPrediction = value; OnPropertyChanged(); }
            }

            public int IncorrectPrediction
            {
                get => _incorrectPrediction;
                set { _incorrectPrediction = value; OnPropertyChanged(); }
            }

            public int BranchesNumber
            {
                get => _branchesNumber;
                set { _branchesNumber = value; OnPropertyChanged(); }
            }

            public double Accuracy
            {
                get => _accuracy;
                set { _accuracy = value; OnPropertyChanged(); }
            }

            public double Dimness
            {
                get => _dimness;
                set { _dimness = value; OnPropertyChanged(); }
            }

            public ObservableCollection<BranchInfoViewModel> Branches { get; set; } = new();

            public event PropertyChangedEventHandler? PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string name = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public class BranchInfoViewModel
        {
            public int Id { get; set; }
            public int TotalAccesses { get; set; }
            public double PercentageAccesses { get; set; }
            public int CorrectPredictions { get; set; }
            public int IncorrectPredictions { get; set; }
            public double Accuracy { get; set; }
            public double Dimness { get; set; }
        }
    }

}

using System.Windows;
using System.Windows.Interop;

using TagLibraryRe.ViewModel;

namespace TagLibraryRe
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            var workArea = SystemParameters.WorkArea;

            Width = workArea.Width * 0.8;
            Height = workArea.Height * 0.8;

            Left = workArea.Left + (workArea.Width - Width) / 2;
            Top = workArea.Top + (workArea.Height - Height) / 2;
        }
    }
}
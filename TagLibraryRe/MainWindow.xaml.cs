using System.Windows;
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
        }
    }
}
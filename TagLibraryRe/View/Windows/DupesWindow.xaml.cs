using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace TagLibraryRe.View.Windows
{
    /// <summary>
    /// Interaction logic for DupesWindow.xaml
    /// </summary>
    public partial class DupesWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropretyChanged([CallerMemberName] string propretyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propretyName));
        }

        public bool Success = false;
        public string Option;


        private ObservableCollection<string> duplicates;

        public ObservableCollection<string> Duplicates
        {
            get { return duplicates; }
            set { duplicates = value;
                OnPropretyChanged();
            }
        }

        public DupesWindow(List<string> dupes)
        {
            InitializeComponent();
            DataContext = this;
            Duplicates = new ObservableCollection<string>(dupes);

        }

        private void btnProg_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Option = "Prog";
            Close();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please rename or move files with same names! When done, click ok. (You will have to restart library creation)");
            Success = true;
            Option = "User";
            Close();
        }
    }
}

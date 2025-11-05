using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TagLibraryRe.View.Windows
{
    /// <summary>
    /// Interaction logic for LoadLibraryWindow.xaml
    /// </summary>
    public partial class LoadLibraryWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropretyChanged([CallerMemberName] string propretyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propretyName));
        }

        public string finalSelectedLibrary;

        //Data Bindings
        private ObservableCollection<string> libraryNames;

        public ObservableCollection<string> LibraryNames
        {
            get { return libraryNames; }
            set
            {
                libraryNames = value;
                OnPropretyChanged();
            }
        }

        private string selectedLibrary;
        public string SelectedLibrary
        {
            get { return selectedLibrary; }
            set 
            { 
                selectedLibrary = value; 
                OnPropretyChanged(); 
            }
        }

        public LoadLibraryWindow(List<string> libraryNamesArg)
        {
            InitializeComponent();
            DataContext = this;
            libraryNames = new ObservableCollection<string>(libraryNamesArg);
        }


        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            finalSelectedLibrary = SelectedLibrary;
            Close();
        }
    }
}

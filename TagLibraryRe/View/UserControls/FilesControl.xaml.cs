using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TagLibraryRe.ViewModel.UserControls;

namespace TagLibraryRe.View.UserControls
{
    /// <summary>
    /// Interaction logic for FilesControls.xaml
    /// </summary>
    public partial class FilesControl : UserControl
    {
        public FilesControl()
        {
            InitializeComponent();
            FilesControlViewModel vm = new FilesControlViewModel();
            DataContext = vm;
        }
    }
}

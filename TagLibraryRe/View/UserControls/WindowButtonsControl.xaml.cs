using System.Windows.Controls;
using TagLibraryRe.ViewModel.UserControls;

namespace TagLibraryRe.View.UserControls
{
    public partial class WindowButtonsControl : UserControl
    {
        public WindowButtonsControl()
        {
            InitializeComponent();
            WindowButtonsControlViewModel vm = new WindowButtonsControlViewModel();
            DataContext = vm;
        }
    }
}

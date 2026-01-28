using System.Windows.Controls;
using TagLibraryRe.ViewModel.UserControls;

namespace TagLibraryRe.View.UserControls
{
    /// <summary>
    /// Interaction logic for tagControl.xaml
    /// </summary>
    public partial class TagsControl : UserControl
    {
        public TagsControl()
        {
            InitializeComponent();
            TagsControlViewModel vm = new TagsControlViewModel();
            DataContext = vm;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.ViewModel.UserControls;

namespace TagLibraryRe.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _mainViewModel;
        public BaseViewModel MainViewModel { get { return _mainViewModel; } }

        private BaseViewModel _sideViewModel;
        public BaseViewModel SideViewModel { get { return _sideViewModel; } }

        public MainWindowViewModel() 
        {
            _mainViewModel = new MainInitialPlaceHolderControlViewModel();
            _sideViewModel = new TagsDisplayControlViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.Model.EventArgs;
using TagLibraryRe.Model.Stores;
using TagLibraryRe.ViewModel.UserControls;

namespace TagLibraryRe.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _mainViewModel;
        public BaseViewModel MainViewModel { get { return _mainViewModel; }
            set
            {
                _mainViewModel = value;
                OnPropretyChanged();
            }
        }

        private BaseViewModel _sideViewModel;
        public BaseViewModel SideViewModel { get { return _sideViewModel; } 
            set
            {
                _sideViewModel = value;
                OnPropretyChanged();
            }
        }

        public MainWindowViewModel() 
        {
            _mainViewModel = new MainInitialPlaceHolderControlViewModel();
            _sideViewModel = new TagsDisplayControlViewModel();

            EventStore.Instance.ChangeMainVM += ChangeMainVM;
            EventStore.Instance.ChangeSideVM += ChangeSideVM;
        }

        private void ChangeMainVM(object? sender, VMEventArgs e)
        {
            MainViewModel = e.VM;
        }

        private void ChangeSideVM(object? sender, VMEventArgs e)
        {
            SideViewModel = e.VM;
        }

        public override void Dispose()
        {
            EventStore.Instance.ChangeMainVM -= ChangeMainVM;
            EventStore.Instance.ChangeSideVM -= ChangeSideVM;
        }
    }
}

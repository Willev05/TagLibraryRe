using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.Model.Stores;

namespace TagLibraryRe.ViewModel.UserControls
{
    internal class TagsControlViewModel : BaseViewModel
    {
        private readonly RelayCommand _newTag;
        public RelayCommand NewTag {  get { return _newTag; } }

        private readonly RelayCommand _removeTag;
        public RelayCommand RemoveTag { get { return _removeTag; } }

        public TagsControlViewModel()
        {
            _newTag = new RelayCommand(execute=> CreateTag(), canExecute=> TagOperationsCanExecute());
            _removeTag = new RelayCommand(execute=> DeleteTag(), canExecute=> TagOperationsCanExecute());
        }

        private void CreateTag()
        {
            throw new NotImplementedException();
        }

        private void DeleteTag()
        {
            throw new NotImplementedException();
        }

        private bool TagOperationsCanExecute()
        {
            return StateStore.Instance.IsLibraryLoaded;
        }

    }
}

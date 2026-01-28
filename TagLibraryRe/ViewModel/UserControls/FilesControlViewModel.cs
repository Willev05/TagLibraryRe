using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLibraryRe.Model.Stores;

namespace TagLibraryRe.ViewModel.UserControls
{
    internal class FilesControlViewModel
    {
        private readonly RelayCommand _newFile;
        public RelayCommand NewFile { get { return _newFile; } }

        private readonly RelayCommand _loadFile;
        public RelayCommand LoadFile { get { return _loadFile; } }

        private readonly RelayCommand _saveFile;
        public RelayCommand SaveFile { get { return _saveFile; } }
        
        public FilesControlViewModel() 
        {
            _newFile = new RelayCommand(execute=> CreateFile());
            _loadFile = new RelayCommand(execute=> LoadExistingFile());
            _saveFile = new RelayCommand(execute => SaveFileToDisk());
        }

        private void CreateFile()
        {
            StateStore.Instance.IsLibraryLoaded = true;
        }

        private void LoadExistingFile()
        {
            throw new NotImplementedException();
        }

        private void SaveFileToDisk()
        {
            throw new NotImplementedException();
        }
    }
}

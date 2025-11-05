using System.Windows;

namespace TagLibraryRe.ViewModel.UserControls
{
    class WindowButtonsControlViewModel
    {
        private readonly RelayCommand _closeCommand;
        public RelayCommand CloseCommand { get { return _closeCommand; } }

        private readonly RelayCommand _maximizeCommand;
        public RelayCommand MaximizeCommand { get { return _maximizeCommand; } }

        private readonly RelayCommand _minimizeCommand;
        public RelayCommand MinimizeCommand { get { return _minimizeCommand; } }

        public WindowButtonsControlViewModel() {
            _closeCommand = new RelayCommand(execute => Close());
            _maximizeCommand = new RelayCommand(execute => Maximize());
            _minimizeCommand = new RelayCommand(execute => Minimize());
        }
        private void Close()
        {
            Application.Current.MainWindow.Close();
        }

        private void Maximize()
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        }

        private void Minimize()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}

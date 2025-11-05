using System.Windows;

namespace TagLibraryRe.View.Windows
{
    /// <summary>
    /// Interaction logic for FileTypesWindow.xaml
    /// </summary>
    public partial class FileTypesWindow : Window
    {

        public List<string> CheckedTypes = new List<string>();
        public bool Success = false;
        
        public FileTypesWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (png.IsChecked == true)
            {
                CheckedTypes.Add("*.png");
            }
            if (jpg.IsChecked == true)
            {
                CheckedTypes.Add("*.jpg");
                CheckedTypes.Add("*.jpeg");
            }
            if (webp.IsChecked == true)
            {
                CheckedTypes.Add("*.webp");
            }
            if (jfif.IsChecked == true)
            {
                CheckedTypes.Add("*.jfif");
            }

            Success = true;

            Close();
        }
    }
}

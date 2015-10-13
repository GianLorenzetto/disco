using System.Windows;

namespace Disco
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainWindow.Title = "Disco - " + Properties.Settings.Default.TitleVersionString;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

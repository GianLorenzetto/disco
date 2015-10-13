using System.Configuration;
using System.Diagnostics;
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
            mainWindow.Title = MakeTitleVersionString();
        }

        private static string MakeTitleVersionString()
        {
            var version = GetAssemblyVersionString();
            return $"Disco - v{version} [{ConfigurationManager.AppSettings["TitleVersionString"]}]";
        }

        private static string GetAssemblyVersionString()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

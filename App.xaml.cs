using System.Configuration;
using System.Data;
using System.Windows;

namespace Fitness
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        readonly MainWindow mainWindow;

        // через систему внедрения зависимостей получаем объект главного окна
        public App(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            mainWindow.Show();  // отображаем главное окно на экране
            base.OnStartup(e);
        }
    }

}

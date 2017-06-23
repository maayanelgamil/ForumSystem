using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ForumSystemProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IController controller = ForumSystem.getInstance();
            MainWindow view = new MainWindow();
            controller.setView(view);
            view.Show();
        }
    }
}

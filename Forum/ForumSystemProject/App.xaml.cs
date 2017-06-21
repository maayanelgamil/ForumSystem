using ForumSystemProject.Controller;
using ForumSystemProject.Model;
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
            IController controller = null;//new Controller.Controller();
                                          // IModel model = ForumSystem.getInstance(controller);
            MainWindow view = new MainWindow(ref controller);
            //controller.setModel(model);
            //controller.setView(view);
            view.Show();
        }
    }
}

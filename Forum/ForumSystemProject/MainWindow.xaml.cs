using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ForumSystemProject.Controller;
using ForumSystemProject.View;

namespace ForumSystemProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IController controller;

        public MainWindow()
        {
            //InitializeComponent();
        }

        public MainWindow(ref IController _controller) : base()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            controller = _controller;
        }

        private void RegWin_Closed(object sender, EventArgs e)
        {
            Visibility = Visibility.Visible;
        }

        private void login_click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(controller);
            this.Visibility = Visibility.Hidden;
            loginWindow.Closed += LoginWindow_Closed;
            loginWindow.Show();
        }

        private void LoginWindow_Closed(object sender, EventArgs e)
        {
            Visibility = Visibility.Visible;
        }

        private void register_click(object sender, RoutedEventArgs e)
        {
            //Register_window RegWin = new Register_window(controller);
            Visibility = Visibility.Hidden;
            //RegWin.Closed += RegWin_Closed;
            //RegWin.Show();
        }
    }
}

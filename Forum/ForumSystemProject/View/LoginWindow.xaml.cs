using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
using System.Windows.Shapes;

namespace ForumSystemProject.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        IController controller;

        /// <summary>
        /// C'tor for the LoginWindow class
        /// </summary>
        /// <param name="_controller"></param>
        public LoginWindow(ref IController _controller)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            controller = _controller;
        }

        /// <summary>
        /// This function defines the actions taken after the user pressed the 'connect' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_connect_Click(object sender, RoutedEventArgs e)
        {
            UserAccount user = controller.connect(tb_mail.Text, tb_password.Text);
            if (user == null)
                MessageBox.Show("Username or Password is invalid. please try again!");
            else
            {
                UserWindow userWin = new UserWindow(tb_mail.Text, controller, user);
                Visibility = Visibility.Hidden;
                userWin.Closed += UserWin_Closed;
                userWin.Show();
            }
        }

        private void UserWin_Closed(object sender, EventArgs e)
        {
            Close();
        }
    }
}

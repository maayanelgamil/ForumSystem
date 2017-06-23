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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        IController controller;
        string userName;

        public UserWindow(string name, IController _controller, UserAccount user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            controller = _controller;
            this.userName = name;

            txt_firstName.Text = "," + name;
        }


        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            Search_window searchWin = new Search_window(controller);
            Visibility = Visibility.Hidden;
            searchWin.Closed += SearchWin_Closed;
            searchWin.Show();
        }

        private void SearchWin_Closed(object sender, EventArgs e)
        {
            Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("אופציה זו אינה נתמכת בגירסה הנוכחית");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("אופציה זו אינה נתמכת בגירסה הנוכחית");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //CreateProfileByInterestArea_window addProfileWindow = new CreateProfileByInterestArea_window(controller, mail);
            //addProfileWindow.Closed += addProfileWindow_Closed; //close this window when add profile is closed
            ///this.Visibility = Visibility.Hidden; //hide this window until add profile ended
            //addProfileWindow.Show();
        }

        void addProfileWindow_Closed(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }


    }
}

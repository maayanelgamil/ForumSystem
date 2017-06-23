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
        public List<SubForum> subForums { get; set; }

        public UserWindow(string name, IController _controller, UserAccount user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            controller = _controller;
            this.userName = name;
            subForums = new List<SubForum>();
            subForums = user.memeberOf.getSubforums();
            this.DataContext = this;

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

        void watch_Click(object sender, EventArgs e)
        {
            if (dropDown.SelectedItem == null)
                MessageBox.Show("No sub forum chosen!");
            else
            {
                Discussions_window disWin = new Discussions_window(ref controller,(SubForum)dropDown.SelectedItem);
                disWin.Show();
                this.Visibility = Visibility.Hidden;
                disWin.Closed += disWin_Closed;
            }
        }

        private void disWin_Closed(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }


        void addProfileWindow_Closed(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

    }
}

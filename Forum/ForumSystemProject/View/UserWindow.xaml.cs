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
        UserAccount _user;
        public List<SubForum> subForums { get; set; }

        public UserWindow(string name, IController _controller, UserAccount user)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            controller = _controller;
            this.userName = name;
            _user = user;
            subForums = new List<SubForum>();
            subForums = user.memeberOf.getSubforums();
            this.DataContext = this;

            txt_firstName.Text = "," + name;
        }

        void watch_Click(object sender, EventArgs e)
        {
            if (dropDown.SelectedItem == null)
                MessageBox.Show("No sub forum chosen!");
            else
            {
                Discussions_window disWin = new Discussions_window(ref controller, (SubForum)dropDown.SelectedItem);
                disWin.Show();
                this.Visibility = Visibility.Hidden;
                disWin.Closed += disWin_Closed;
            }
        }

        private void disWin_Closed(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }

        private void dropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dropDown.SelectedValue != null)
            {
                this.button_add.Visibility = Visibility.Visible;
            }
            else
            {
                this.button_add.Visibility = Visibility.Hidden;
            }
        }


        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            addDiscussionView add = new addDiscussionView(ref controller, _user, (SubForum)dropDown.SelectedItem);
            this.Visibility = Visibility.Hidden;
            add.Show();
            add.Closed += showSelf;
        }

        private void showSelf(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
        }
    }
}

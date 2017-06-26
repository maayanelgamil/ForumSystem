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
using System.Windows.Shapes;

using ForumSystemProject.Controller;

namespace ForumSystemProject.View
{
    /// <summary>
    /// Interaction logic for AddSportsProfile.xaml
    /// </summary>
    public partial class addDiscussionView : Window
    {
        private IController _controller;
        private UserAccount _user;
        private SubForum _sf;

        public addDiscussionView(ref IController controller, UserAccount user, SubForum sf)
        {
            InitializeComponent();
            _controller = controller;
            _user = user;
            _sf = sf;
        }

        private void b_confirm_Click(object sender, RoutedEventArgs e)
        {
            if (tb_subject.Text.Equals("") || tb_content.Text.Equals("") || tb_title.Text.Equals(""))
                MessageBox.Show("Please fill in all the fields");
            else
            {
                bool success = _controller.newDisscussion(_user.memeberOf.forumID, _sf, tb_subject.Text,
                     _user.UserName, tb_title.Text, tb_content.Text);
                if (success)
                {
                    MessageBox.Show("Discussion was add successfully");
                    this.Close();

                }
                else
                    MessageBox.Show("Discussion failed, subject already exists in this subforum");
            }
        }
    }
}

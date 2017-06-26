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
        private string _userName;

        public addDiscussionView(ref IController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void b_confirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

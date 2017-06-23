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
        private IController controller;
        private string mail;

        public addDiscussionView()
        {
            InitializeComponent();
        }
    }
}

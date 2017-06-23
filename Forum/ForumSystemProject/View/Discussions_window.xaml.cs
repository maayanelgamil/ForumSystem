using ForumSystemProject.Controller;
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

namespace ForumSystemProject.View
{
    /// <summary>
    /// Interaction logic for Discussions_window.xaml
    /// </summary>
    public partial class Discussions_window : Window
    {
        IController controller;
        public List<Disscusion> discussions { get; set; }

        public Discussions_window(ref IController _controller, SubForum current)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            controller = _controller;
            discussions = new List<Disscusion>();
            discussions = current.getDiscussions();
            this.DataContext = this;
        }



    }
}

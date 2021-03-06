﻿using System;
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
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ForumSystemProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        IController controller;


        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //controller = ForumSystem.deserialize();
            controller = ForumSystem.getInstance();
        }

        private void RegWin_Closed(object sender, EventArgs e)
        {
            Visibility = Visibility.Visible;
        }

        private void login_click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(ref controller);
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
            Register_window RegWin = new Register_window(ref controller);
            Visibility = Visibility.Hidden;
            RegWin.Closed += RegWin_Closed;
            RegWin.Show();
        }

        private void mainWindow_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                Stream TestFileStream = File.Create("forumSystem.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(TestFileStream, controller);
                TestFileStream.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Bye Bye");
            }
        }

        private void guest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This button has no implemenation at the moment.");
        }
    }
}

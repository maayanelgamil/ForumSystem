using ForumSystemProject.Controller;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Net.Mail;
using System.Windows;
using System.Windows.Navigation;

namespace ForumSystemProject.View
{
    /// <summary>
    /// Interaction logic for Register_window.xaml
    /// </summary>
    public partial class Register_window : Window
    {
        IController controller;

        /// <summary>
        /// C'tor for the Register window
        /// </summary>
        public Register_window(ref IController _controller)
        {
            controller = _controller;
            InitializeComponent();
        }

        /// <summary>
        /// the event when the fun button is cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_fin_Click(object sender, RoutedEventArgs e)
        {
            if (!IsInputValid())
                return; //need to display error here **************
            if (!isUserNameExists(tb_userName.Text))
                return; //need to display error here
            //here sign to data table
        }

        /// <summary>
        /// This function checks whether an email already exists in the DB
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>true is userName exists</returns>
        private bool isUserNameExists(string userName)
        {
            return controller.isUserExists(userName);

        }


        /// <summary>
        /// checks if the input is valid
        /// </summary>
        private bool IsInputValid()
        {
            if ( tb_firstName.Text == "" || tb_lastName.Text == "" || tb_mail.Text == "" || tb_password.Text == "" || tb_userName.Text== "" ) ///************ need to fix *************///
            {
                MessageBox.Show("יש למלא את כל השדות");
                return false;
            }
            return true;
            //************************************************************************************************
            //need to check if the mail is valid and if the phone is valid and if the password is at least 8 chars
        }

        /// <summary>
        /// This function activates the hyperlink to the regulations of yad2 website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}

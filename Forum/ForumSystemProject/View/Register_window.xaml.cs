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
        public List<Forum> forums { get; set; }
        /// <summary>
        /// C'tor for the Register window
        /// </summary>
        public Register_window(ref IController _controller)
        {
            forums = new List<Forum>();
            controller = _controller;
            InitializeComponent();
            forums = _controller.getForums();
            this.DataContext = this;
        }

        /// <summary>
        /// the event when the fun button is cliked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void done_Click(object sender, RoutedEventArgs e)
        {
            if (!IsInputValid())
                return; //need to display error here **************
            else if (!isUserNameExists(tb_userName.Text))
            {
                Forum f = (Forum)dropDown.SelectedValue;
                controller.newUserAccount(f, this.tb_userName.Text, tb_password.Text, tb_firstName.Text, tb_lastName.Text, tb_mail.Text);
                MessageBox.Show("Registration completed");
                this.Close();
            }
            else MessageBox.Show("User name already exists");

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
            if (tb_firstName.Text == "" || dropDown.SelectedValue == null || tb_lastName.Text == "" || tb_mail.Text == "" || tb_password.Text == "" || tb_userName.Text == "") ///************ need to fix *************///
            {
                MessageBox.Show("Fill in all fields");
                return false;
            }
            return true;
            //************************************************************************************************
            //need to check if the mail is valid and if the phone is valid and if the password is at least 8 chars
        }
    }
}

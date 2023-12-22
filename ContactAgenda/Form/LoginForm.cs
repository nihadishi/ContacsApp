﻿using System;
using System.Configuration;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance { get; } = new LoginForm();

        //private UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        #region Events

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        #endregion

        #region Methods

        private void RegisterNewUser()
        {
            RegisterUserForm newRegisterForm = new RegisterUserForm();
            newRegisterForm.Show();
            this.Hide();
        }

        private void LoginUser()
        {
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;


            if(username == "nihad" && password == "12345678")
            {


                ContactsForm newContactsForm = new ContactsForm();
                newContactsForm.Show();
                this.Hide();

                TxtBxUsername.Clear();
                TxtBxPassword.Clear();

            }
            else if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please complete all fields to login.", "Warning!");
            }
            else
            {
                MessageBox.Show("Username or password are incorrect.", "Warning!");
            }
        }

        #endregion
    }
}

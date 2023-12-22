using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class RegisterUserForm : Form
    {

        public RegisterUserForm()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;  // CS_NOCLOSE
                return parms;
            }
        }

        #region Events

        private void RegisterUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegisterNewUser();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void RegisterNewUser()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastname.Text;
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;
            string confirmPassword = TxtBxConfirmPassword.Text;


            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
           
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords are not the same.", "Warning!");
            }
            else
            {

                if(true)
                {
                    DialogResult response = MessageBox.Show("User created successfully.", "Notification!", MessageBoxButtons.OK);

                    if (response == DialogResult.OK)
                    {
                        CloseForm();
                    }
                }
                else
                {
                    MessageBox.Show("There was a problem creating the user, try again later.", "Error!");
                }
            }
        }

        private void CloseForm()
        {
            this.Close();
        }

        #endregion
    }
}

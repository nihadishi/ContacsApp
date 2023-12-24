using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class RegisterUserForm : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        public RegisterUserForm()
        {
            InitializeComponent();
            InitializeErrorProvider();


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
        private void InitializeErrorProvider()
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
        }

        private void RegisterNewUser()
        {

            if (CheckUserCredentials() == true)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Users(Name,LastName,Username,Password) VALUES(@name,@lastname,@username,@password)", connection))
                    {
                        command.Parameters.AddWithValue("@name", TxtBxName.Text);
                        command.Parameters.AddWithValue("@lastname", TxtBxLastname.Text);
                        command.Parameters.AddWithValue("@username", TxtBxUsername.Text);
                        command.Parameters.AddWithValue("@password", TxtBxPassword.Text);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                DialogResult response = MessageBox.Show("User created successfully.", "Notification!", MessageBoxButtons.OK);

                                if (response == DialogResult.OK)
                                {
                                    CloseForm();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving text: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Enter all of required informations");
            }
        }



        private void CloseForm()
        {
            this.Close();
        }

        private bool CheckUserCredentials()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastname.Text;
            string username = TxtBxUsername.Text;
            string password = TxtBxPassword.Text;
            string confirmPassword = TxtBxConfirmPassword.Text;

            if (name != null && lastName != null && username != null && password != null && confirmPassword != null && confirmPassword == password) return true;
            return false;

        }

        #endregion
    }
}

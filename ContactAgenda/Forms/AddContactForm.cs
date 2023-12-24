//using BusinessLayer.Service;
//using Database.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class AddContactForm : Form
    {
        //private ContactService _contactService;

        public AddContactForm()
        {
            InitializeComponent();

            //string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            //SqlConnection connection = new SqlConnection(connectionString);

            // _contactService = new ContactService(connection);
        }

        // Disable window close button.
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

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            LoadContactToEdit();
        }

        private void AddContactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ContactsForm.Instance.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        #endregion

        #region Methods

        private void AddContact()
        {
            string name = TxtBxName.Text;
            string lastName = TxtBxLastName.Text;
            string address = TxtBxAddress.Text;
            string phoneNumber = TxtBxPhoneNumber.Text;
            string workNumber = TxtBxWorkNumber.Text;

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(address) || !TxtBxPhoneNumber.MaskCompleted || !TxtBxWorkNumber.MaskCompleted)
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Contacts(Name,LastName,Address,PhoneNumber,WorkNumber,UserId) VALUES(@name,@lastname,@address,@phonenumber,@worknumber,@userid)", connection))
                    {
                        command.Parameters.AddWithValue("@name", TxtBxName.Text);
                        command.Parameters.AddWithValue("@lastname", TxtBxLastName.Text);
                        command.Parameters.AddWithValue("@address", TxtBxAddress.Text);
                        command.Parameters.AddWithValue("@phonenumber", TxtBxPhoneNumber.Text);
                        command.Parameters.AddWithValue("@worknumber", TxtBxWorkNumber.Text);
                        command.Parameters.AddWithValue("@userid", LoginForm.userID);


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
        }

        private void LoadContactToEdit()
        {
        }


        private void CloseForm()
        {
            this.Close();
        }

        #endregion

        private void TlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtBxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

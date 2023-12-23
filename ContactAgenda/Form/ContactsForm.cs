using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class ContactsForm : Form
    {
        public static ContactsForm Instance { get; } = new ContactsForm();

        public ContactsForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        #region Events

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void ContactsForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Show();
        }

        private void MsItemLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void DgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteContact();
        }

        #endregion

        #region Methods

        private void LoadContacts()
        {
            List<string> contacts= new List<string>();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command=new SqlCommand("SELECT *FROM Contacts WHERE USER_ID=@userid",connection))
                {
                    command.Parameters.AddWithValue("@user_id", LoginForm.userID);
                    using(SqlDataReader reader=command.ExecuteReader())
                    {
                        try
                        {
                            if(reader.Read())
                            {
                                contacts.Add(reader.GetString(0));
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK);
                        }
                    }
                }
            }
            DgvContacts.ClearSelection();
        }

        private void Logout()
        {
            CloseForm();
        }

        private void AddContact()
        {
            AddContactForm newAddContactForm = new AddContactForm();
            newAddContactForm.Show();
            this.Hide();
        }

        private void EditContact()
        {

            MessageBox.Show("Please select a contact.", "Warning!");
        }

        private void DeleteContact()
        {

            DialogResult response = MessageBox.Show("Are you sure you want to delete this contact?",
                "Warning!", MessageBoxButtons.OKCancel);

            if (response == DialogResult.OK)
            {
                if (true)
                {
                    MessageBox.Show("Contact deleted successfully.", "Notification!");
                }
                else
                {
                    MessageBox.Show("There was a problem, try again later.", "Error!");
                }

                LoadContacts();
            }
        }

        private void CloseForm()
        {
            LoginForm.Instance.Show();
            this.Hide();
        }

        #endregion
    }
}

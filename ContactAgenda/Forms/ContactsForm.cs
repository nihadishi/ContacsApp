using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT *FROM Contacts WHERE UserId=@userid", connection))
                    {
                        command.Parameters.AddWithValue("@userid", LoginForm.userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                DataTable datas = new DataTable();
                                datas.Columns.Add("Name", typeof(string));
                                datas.Columns.Add("Lastname", typeof(string));
                                datas.Columns.Add("Address", typeof(string));
                                datas.Columns.Add("PhoneNumber", typeof(string));
                                datas.Columns.Add("WorkNumber", typeof(string));

                                // Populate the DataTable with contact data
                                do
                                {
                                    datas.Rows.Add(reader["Name"], reader["Lastname"], reader["Address"], reader["PhoneNumber"], reader["WorkNumber"]);
                                } while (reader.Read());

                                // Bind the DataTable to the DataGridView
                                DgvContacts.DataSource = datas;


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
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
            if (DgvContacts.SelectedRows.Count == 1)
            {
                Edit e = new Edit();
                e.name = DgvContacts.SelectedRows[0].Cells[0].Value.ToString();
                e.lastname = DgvContacts.SelectedRows[0].Cells[1].Value.ToString();
                e.address = DgvContacts.SelectedRows[0].Cells[2].Value.ToString();
                e.phonenumber = DgvContacts.SelectedRows[0].Cells[3].Value.ToString();
                e.worknumber = DgvContacts.SelectedRows[0].Cells[4].Value.ToString();
                e.Show();
            }
            else
            {
                MessageBox.Show("Please select a contact.", "Warning!");
            }
        }
        private void DeleteContact()
        {

            if (DgvContacts.SelectedRows.Count > 0)
            {
                try
                {
                    string name = DgvContacts.SelectedRows[0].Cells["Name"].Value.ToString();
                    string lastname = DgvContacts.SelectedRows[0].Cells["Lastname"].Value.ToString();
                    string address = DgvContacts.SelectedRows[0].Cells["Address"].Value.ToString();
                    string phonenumber = DgvContacts.SelectedRows[0].Cells["PhoneNumber"].Value.ToString();
                    string worknumber = DgvContacts.SelectedRows[0].Cells["WorkNumber"].Value.ToString();

                    string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM Contacts WHERE Name=@name AND Lastname=@lastname AND @Address=@address AND PhoneNumber=@phonenumber AND WorkNumber=@worknumber AND UserId=@userid", connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@lastname", lastname);
                            command.Parameters.AddWithValue("@address", address);
                            command.Parameters.AddWithValue("@phonenumber", phonenumber);
                            command.Parameters.AddWithValue("@worknumber", worknumber);
                            command.Parameters.AddWithValue("@userid", LoginForm.userID);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Contact deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Contact could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select a contact.", "Warning!");
            }

            LoadContacts();

        }

        private void CloseForm()
        {
            LoginForm.Instance.Show();
            this.Hide();
        }

        #endregion

        private void DgvContacts_DoubleClick(object sender, EventArgs e)
        {
            LoadContacts();
        }
    }
}

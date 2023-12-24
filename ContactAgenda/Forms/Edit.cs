using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContactAgenda
{
    public partial class Edit : Form
    {
        public string name;
        public string lastname;
        public string address;
        public string phonenumber;
        public string worknumber;
        public string userid;

        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            TxtBxName.Text = name;
            TxtBxLastName.Text = lastname;
            TxtBxAddress.Text = address;
            TxtBxPhoneNumber.Text = phonenumber;
            TxtBxWorkNumber.Text = worknumber;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(TxtBxLastName.Text) || String.IsNullOrEmpty(TxtBxName.Text) || String.IsNullOrEmpty(TxtBxPhoneNumber.Text) || !TxtBxPhoneNumber.MaskCompleted || !TxtBxWorkNumber.MaskCompleted)
            {
                MessageBox.Show("Please complete all fields in the form.", "Warning!");
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("UPDATE Contacts SET Name=@name, LastName=@lastname, Address=@address, PhoneNumber=@phonenumber, WorkNumber=@worknumber WHERE Name=@originalName AND Lastname=@originalLastname AND Address=@originalAddress AND PhoneNumber=@originalPhoneNumber AND WorkNumber=@originalWorknumber AND UserId=@userid", connection))
                    {
                        command.Parameters.AddWithValue("@name", TxtBxName.Text);
                        command.Parameters.AddWithValue("@lastname", TxtBxLastName.Text);
                        command.Parameters.AddWithValue("@address", TxtBxAddress.Text);
                        command.Parameters.AddWithValue("@phonenumber", TxtBxPhoneNumber.Text);
                        command.Parameters.AddWithValue("@worknumber", TxtBxWorkNumber.Text);

                        command.Parameters.AddWithValue("@originalName", name);  
                        command.Parameters.AddWithValue("@originalLastname", lastname);
                        command.Parameters.AddWithValue("@originalAddress", address);  
                        command.Parameters.AddWithValue("@originalPhoneNumber", phonenumber);
                        command.Parameters.AddWithValue("@originalWorknumber", worknumber);
                        command.Parameters.AddWithValue("@userid", LoginForm.userID);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                DialogResult response = MessageBox.Show("User edited successfully.", "Notification!", MessageBoxButtons.OK);

                                if (response == DialogResult.OK)
                                {
                                    this.Hide();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

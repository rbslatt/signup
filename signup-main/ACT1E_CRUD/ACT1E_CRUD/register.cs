using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ACT1E_CRUD
{
    public partial class register : Form
    {
        private MySqlConnection connection;
        public register()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=robertdb;username=root;password=;");
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string username = txtUsername.Text.Trim();



            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("PLEASE ENTER BOTH USERNAME AND PASSWPORD");

            }

            try {
                connection.Open();
                string loginquery = "INSERT INTO userss (username, password, name) VALUES (@username, @password, @name)";
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@name", name);

                int rowaffected = command.ExecuteNonQuery();
                if (rowaffected > 0)
                {
                    MessageBox.Show("");
                }




            }

            catch (Exception ex)
            {
                MessageBox.Show ("Error: " +  ex.Message);
            }


            finally { 
            
               if (connection.State == System.Data.ConnectionState.Open )
                {
                    connection
                        .Close();
                }
            
            }


        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}

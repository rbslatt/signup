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
    public partial class admin : Form
    {
        private MySqlConnection connection;
        public admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=robertdb;username=root;password=;");
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }
    }    private void
   
}

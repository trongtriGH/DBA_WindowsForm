using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsProject
{
    public partial class Menuform : Form
    {
        public static string connectionString = @"Data Source=(DESCRIPTION=
                                                      (ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-JE6DKP3)(PORT=1521))
                                                      (CONNECT_DATA=(SERVICE_NAME=xe)));
                                                      User Id=dba_test;Password=dba123;";
        public Menuform()
        {
            InitializeComponent();
        }

        private void button_view_user_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM SYS.DBA_USERS";

                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

                    dgv1.DataSource = dtbl;

                    connection.Close();
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Oracle Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

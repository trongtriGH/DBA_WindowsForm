using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class Form1 : Form
    {
        public static string connectionString = @"Data Source=(DESCRIPTION=
                                                      (ADDRESS=(PROTOCOL=TCP)(HOST=DESKTOP-JE6DKP3)(PORT=1521))
                                                      (CONNECT_DATA=(SERVICE_NAME=xe)));
                                                      User Id=dba_test;Password=dba123;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM DBA_TEST.Login_info WHERE USERNAME = :username AND PASSWORD = :password";

                    OracleCommand command = new OracleCommand(query, connection);
                    command.Parameters.Add(new OracleParameter("username", username));
                    command.Parameters.Add(new OracleParameter("password", password));

                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dtbl = new DataTable();
                    adapter.Fill(dtbl);

      
                    if (dtbl.Rows.Count > 0)
                    {
                        Menuform form2 = new Menuform();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Clear();
                        txt_password.Focus();
                    }

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

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }
    }
}

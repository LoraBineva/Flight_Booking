using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;
using static Flights_Agency_App.Authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Flights_Agency_App
{
    public partial class Log_In : Form
    {
        SqlConnection sql;
        public Log_In()
        {
            InitializeComponent();
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Flight_Agency; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void log_in_btn_Click(object sender, EventArgs e)
        {
            string username_inp = username.Text;
            string password_inp = password.Text;

            if (!string.IsNullOrWhiteSpace(username_inp) && !string.IsNullOrWhiteSpace(password_inp))
            {
                Authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(username_inp, password_inp);

                if (authenticatedUser != null)
                {
                    string insertUsername = "Insert Into Booking Values (@username, NULL)";
                    SqlCommand cmd = new SqlCommand(insertUsername, sql);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@username", authenticatedUser.Username);
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    Form1 form = new Form1(authenticatedUser);
                    form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void log_in_btn_MouseHover(object sender, EventArgs e)
        {
            log_in_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void register_btn_MouseHover(object sender, EventArgs e)
        {
            register_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}

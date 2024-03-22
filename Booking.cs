using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights_Agency_App
{
    public partial class Booking : Form
    {
        public string flightID;
        SqlConnection sql;
        Authenticate.User userToBeUSED = new Authenticate.User();

        public Booking(string flightNum, Authenticate.User user)
        {
            InitializeComponent();
            flightID = flightNum;
            userToBeUSED = user;

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            try
            {
                sql = new SqlConnection(@"Data Source=LAB109PC01\SQLEXPRESS; Initial Catalog=Flight_Agency; Integrated Security=True;");
                sql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            flightID_lbl.Text = $"FlightID : {flightID}";
            string fetchFlight = "SELECT * From Flights WHERE flightID = @flightID ";
            SqlCommand cmd = new SqlCommand(fetchFlight, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@flightID", flightID);
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Flight_Data.DataSource = ds.Tables[0];
            }
            passengerName_lbl.Text = $"Passenger Name: {userToBeUSED.First_Name} {userToBeUSED.Last_Name}";
            DOB_lbl.Text = $"Date of Birth: {userToBeUSED.DOB}";

        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            string fetchFlight = "Update Booking Set flightID=@flightID where username=@username";
            SqlCommand cmd = new SqlCommand(fetchFlight, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", userToBeUSED.Username);
            cmd.Parameters.AddWithValue("@flightID", flightID);
            cmd.ExecuteNonQuery();
            MessageBox.Show($"Congradulations {userToBeUSED.First_Name} {userToBeUSED.Last_Name} you have booked your flight!", "BRAVOOO", MessageBoxButtons.OK);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            string deleteBooking = "Delete From Booking WHERE username=@username";
            SqlCommand cmd = new SqlCommand(deleteBooking, sql);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", userToBeUSED.Username);
            cmd.ExecuteNonQuery();

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking? If you do, you would need to log-in again!", "Sure?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking succesfully canceled!", "Deleted", MessageBoxButtons.OK);
                this.Hide();
                Log_In log_In = new Log_In();
                log_In.Show();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Your booking was not canceled!", "Not Deleted", MessageBoxButtons.OK);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1(userToBeUSED);
            form1.ShowDialog();
        }
    }
}

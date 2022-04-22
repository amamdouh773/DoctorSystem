using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Doctory.DAL;
namespace Doctory.UI
{
    public partial class Appointments : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public Appointments()
        {
          InitializeComponent();
          //con = new SqlConnection(@"Data Source=(Local);Initial Catalog=Doctory;Integrated Security=True");
          //con.Open();
          //cmd = new SqlCommand("INSERT INTO workingTime  (doctorTime_id,sunday,monday,tuesday,wednesday,thursday,friday,saturday) VALUES (@doctorTime_id,@sunday,@monday,@tuesday,@wednesday,@thursday,@friday,@saturday)", con);
          //cmd.Parameters.AddWithValue("@doctorTime_id", loginDAL.doctor_get_data.doctor_id);
          //cmd.Parameters.AddWithValue("@sunday", sun.Text);
          //cmd.Parameters.AddWithValue("@monday", mon.Text);
          //cmd.Parameters.AddWithValue("@tuesday", tues.Text);
          //cmd.Parameters.AddWithValue("@wednesday", wed.Text);
          //cmd.Parameters.AddWithValue("@thursday", thr.Text);
          //cmd.Parameters.AddWithValue("@friday", fri.Text);
          //cmd.Parameters.AddWithValue("@saturday", sat.Text);
          //cmd.ExecuteNonQuery();
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            doctor_module show_docotor = new doctor_module();
            show_docotor.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySchedule show_schedule = new mySchedule();
            show_schedule.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            Appointments show_appointment = new Appointments();
            show_appointment.Show();
            this.Hide();
        }

        private void My_profile_Click(object sender, EventArgs e)
        {
            doctor_profile_module show_profile = new doctor_profile_module();
            show_profile.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(Local);Initial Catalog=Doctory;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("UPDATE workingTime SET sunday = @sunday,monday = @monday,tuesday = @tuesday,wednesday = @wednesday,thursday = @thursday,friday = @friday,saturday = @saturday ", con);
            cmd.Parameters.AddWithValue("@sunday", sunday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@monday", monday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@tuesday", tuesday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@wednesday", wednesday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@thursday", thursday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@friday", friday.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@saturday", saturday.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

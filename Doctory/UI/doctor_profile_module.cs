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
using Doctory.Business_logic_layer;
namespace Doctory.UI
{
    public partial class doctor_profile_module : Form
    {
            SqlConnection con;
            SqlCommand cmd;
        public doctor_profile_module()
        {
            InitializeComponent();
            id_fld.Text = loginDAL.doctor_get_data.doctor_id.ToString();
            first_name.Text = loginDAL.doctor_get_data.first_name.ToString();
            last_name.Text = loginDAL.doctor_get_data.last_name.ToString();
            phone_field.Text = loginDAL.doctor_get_data.phone.ToString();
            textBox1.Text = loginDAL.doctor_get_data.doctor_adress.ToString();
            textBox5.Text = loginDAL.doctor_get_data.doctor_affiliation.ToString();
            textBox2.Text = loginDAL.doctor_get_data.doctor_speciality.ToString();
            textBox3.Text = loginDAL.doctor_get_data.doctor_affiliation.ToString();
            textBox4.Text = loginDAL.doctor_get_data.doctor_rate.ToString();
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void doctor_profile_module_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            con = new SqlConnection(@"Data Source=(Local);Initial Catalog=Doctory;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("DELETE FROM workingTime WHERE doctorTime_id = 1");
            cmd.ExecuteNonQuery();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            doctor_module show_doctor_module = new doctor_module();
            show_doctor_module.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }

        private void My_profile_Click(object sender, EventArgs e)
        {
            doctor_profile_module show_profile = new doctor_profile_module();
            show_profile.Show();
            this.Hide();
        }

        private void id_fld_Click(object sender, EventArgs e)
        {
        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySchedule schedule_show = new mySchedule();
            schedule_show.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
            this.Hide();
        }
    }
}

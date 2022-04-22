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
    public partial class doctor_module : Form
    {
        
        public doctor_module()
        {
            InitializeComponent();
            doctorName.Text = loginDAL.doctor_get_data.first_name  + loginDAL.doctor_get_data.last_name;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void My_profile_Click(object sender, EventArgs e)
        {
            doctor_profile_module show_profile_module = new doctor_profile_module();
            show_profile_module.Show();
            this.Hide();
        }

        private void doctor_module_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            Appointments show_appointment = new Appointments();
            show_appointment.Show();
            this.Hide();
        }

        private void Appointment_btn_Click(object sender, EventArgs e)
        {
            mySchedule show_schedule = new mySchedule();
            show_schedule.Show();
            this.Hide();
        }
    }
}

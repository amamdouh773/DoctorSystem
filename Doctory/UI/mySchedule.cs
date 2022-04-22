using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doctory.UI
{
    public partial class mySchedule : Form
    {
        public mySchedule()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySchedule schedule_show = new mySchedule();
            schedule_show.Show();
            this.Hide();
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            Appointments appointments_show = new Appointments();
            appointments_show.Show();
            this.Hide();
        }

        private void My_profile_Click(object sender, EventArgs e)
        {
            doctor_profile_module show_profile = new doctor_profile_module();
            show_profile.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            doctor_module show_doctor = new doctor_module();
            show_doctor.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

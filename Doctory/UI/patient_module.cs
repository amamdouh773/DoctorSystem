using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Doctory.UI;
using Doctory.DAL;
using Doctory.Business_logic_layer;
namespace Doctory.UI
{
    public partial class patient_module : Form
    {
        public patient_module()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_profile_module show_profile_module = new Patient_profile_module();
            show_profile_module.Show();
            this.Hide();
        }

        private void patient_module_Load(object sender, EventArgs e)
        {
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        Point lastPoint;

        private void main_panel_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void main_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Doctory.Business_logic_layer;
using System.Data.Sql;
using System.Data.SqlClient;
using Doctory.DAL;
namespace Doctory.UI
{
    public partial class login_field : Form
    {
        public login_field()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void login_field_MouseDown(object sender, MouseEventArgs e)
        {
           lastPoint = new Point(e.X, e.Y);

        }
        Point lastPoint;

        private void login_field_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        public static string logged_in_username;
        loginBLL login_data = new loginBLL();
        loginDAL dal = new loginDAL();
        private void login_btn_Click(object sender, EventArgs e)
        {
            login_data.user_name = username_fld.Text;
            login_data.user_password = userpassword_fld.Text;
            string user_role = dal.login_succuss(login_data);
            if(loginDAL.patient_get_data.user_name == username_fld.Text)
            {
                logged_in_username = username_fld.Text;
                patient_module show_patient_module = new patient_module();
                show_patient_module.Show();
                this.Hide();
            }
            else if(loginDAL.doctor_get_data.user_name == username_fld.Text)
            {

                logged_in_username = username_fld.Text;
                doctor_module show_doctor_module = new doctor_module();
                show_doctor_module.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONG USER NAME OR PASSWORD, PLEASE TRY AGAIN!");
            }
        }
    }
}

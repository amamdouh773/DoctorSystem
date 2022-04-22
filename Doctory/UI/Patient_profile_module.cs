using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Doctory.UI;
using Doctory.Business_logic_layer;
using Doctory.DAL;
namespace Doctory.UI
{
    public partial class Patient_profile_module : Form
    {
        
        public Patient_profile_module()
        {
            InitializeComponent();
        }


        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

     
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void main_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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

        private void main_panel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void My_profile_Click(object sender, EventArgs e)
        {
            
        }

        private void Reservation_btn_Click(object sender, EventArgs e)
        {
            patient_module show_patient_module = new patient_module();
            show_patient_module.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
           {
               bool success = false;
               patinetDAL update_database = new patinetDAL();
               patient patient_edited_info = new patient();

               patient_edited_info.patient_id = int.Parse(id_fld.Text);
               patient_edited_info.first_name = first_name.Text;
               patient_edited_info.last_name = last_name.Text;
               patient_edited_info.phone = phone_field.Text;
               patient_edited_info.user_name = username_profile.Text;
               patient_edited_info.user_password = password_fld.Text;
               patient_edited_info.patient_health_description = descrip.Text;
              success =  update_database.update(patient_edited_info);
                if (success) MessageBox.Show("UPDATED SUCCESFULLY");
                else MessageBox.Show("NOT SUCCESFULLY");
           }


        loginDAL dal = new loginDAL();
        private void Patient_profile_module_Load(object sender, EventArgs e)
        {
            id_fld.Text = loginDAL.patient_get_data.patient_id.ToString();
            first_name.Text = loginDAL.patient_get_data.first_name;
            last_name.Text = loginDAL.patient_get_data.last_name;
            phone_field.Text = loginDAL.patient_get_data.phone;
            descrip.Text = loginDAL.patient_get_data.patient_health_description;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void username_profile_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            patient_module show_patient_module = new patient_module();
            show_patient_module.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login_field show_login = new login_field();
            show_login.Show();
            this.Hide();
        }
    }
       
    }


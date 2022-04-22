using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN_PAGE_hospital
{
    public partial class admin_page : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-K079D5L;Initial Catalog=Doctory;Integrated Security=True");

        public admin_page()
        {
            InitializeComponent();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into DOCTOR(user_name,phone,Doctor_adress,Doctor_specialisty,Doctor_affiliation,user_password,first_name,last_name) values ('"+txtfirstname.Text+txtlastname.Text+"','"+txtphone.Text+ "','" + txtaddress.Text + "','" + txtspecialisty.Text + "','" + txtaffilation.Text + "','" + txtpass.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "') ";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            display_data();
            MessageBox.Show("successfully insert");
        }
        public void display_data()
        {
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from  DOCTOR";
           // cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dgvdoctor.DataSource = dt;
            sqlcon.Close();

        }

        private void admin_page_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // display_data();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from DOCTOR where user_name='" + txtname.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            display_data();
            dgvdoctor.Refresh();
            MessageBox.Show("successfully deleted");
            dgvdoctor.Refresh();
        }
    }
}

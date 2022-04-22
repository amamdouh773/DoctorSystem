using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Doctory.Business_logic_layer
{

    class patinetDAL
    {
        static string myconnection = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;



        #region update data FROM Our Module page to the database
        public bool update(patient p)
        {

            SqlConnection conn = new SqlConnection(myconnection);
            conn.Open();
            bool issuccess = false;


            try
            {
                string sql_query = "UPDATE PATIENT SET user_name=@user_name,user_password=@user_password, first_name=@first_name, last_name=@last_name, phone=@phone, patient_medical_status=@patient_health_description "
                + "WHERE patient_id= @patient_id ";

                SqlCommand cmmd = new SqlCommand(sql_query, conn);
                Int32 id = p.patient_id;

                cmmd.Parameters.AddWithValue("@user_name", p.user_name);
                cmmd.Parameters.AddWithValue("@user_password", p.user_password);
                cmmd.Parameters.AddWithValue("@first_name", p.first_name);
                cmmd.Parameters.AddWithValue("@last_name", p.last_name);
                cmmd.Parameters.AddWithValue("@phone", p.phone);
                cmmd.Parameters.AddWithValue("@patient_health_description", p.patient_health_description);
                cmmd.Parameters.AddWithValue("@patient_id", p.patient_id);

                int rows = cmmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }

            return issuccess;

        }

        #endregion

    }
}



    







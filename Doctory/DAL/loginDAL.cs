using Doctory.Business_logic_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using Doctory.DAL;
using Doctory.UI;

namespace Doctory.DAL
{

    class loginDAL
    {
        public static doctor doctor_get_data = new doctor();
        public static patient patient_get_data = new patient();
        static string myconnection = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        #region checking logging
        public string login_succuss(loginBLL login_check)
        {

            SqlConnection conn = new SqlConnection(myconnection);
            SqlConnection connect = new SqlConnection(myconnection);
            try
            {
                conn.Open();

                bool found = false;

                string query = "SELECT patient_id,user_name,user_password,first_name,last_name,phone,user_role,patient_medical_status,user_role FROM PATIENT WHERE user_name =@user_name AND user_password=@user_password";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@user_name", login_check.user_name);
                command.Parameters.AddWithValue("@user_password", login_check.user_password);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    found = true;
                    patient_get_data.patient_id = int.Parse(dr["patient_id"].ToString());
                    patient_get_data.user_name = dr["user_name"].ToString();
                    patient_get_data.user_password = dr["user_password"].ToString();
                    patient_get_data.first_name = dr["first_name"].ToString();
                    patient_get_data.last_name = dr["last_name"].ToString();
                    patient_get_data.phone = dr["phone"].ToString();
                   patient_get_data.patient_health_description = dr["patient_medical_status"].ToString();
                 
                }


                // check if it's doctor and save the data

                else if (found == false)
                {
                    connect.Open();
                    string select_query1 = "SELECT Doctor_id,user_name,user_password,first_name,last_name,phone,Doctor_adress,Doctor_specialisty,Doctor_affiliation,Doctor_rate FROM DOCTOR WHERE user_name =@user_name AND user_password=@user_password";

                    SqlCommand commanddd = new SqlCommand(select_query1, connect);
                    commanddd.Parameters.AddWithValue("@user_name", login_check.user_name);
                    commanddd.Parameters.AddWithValue("@user_password", login_check.user_password);

                    SqlDataReader dt = commanddd.ExecuteReader();
                    if (dt.Read())
                    {
                        found = true;
                        doctor_get_data.doctor_id = int.Parse(dt["Doctor_id"].ToString());
                        doctor_get_data.user_name = dt["user_name"].ToString();
                        doctor_get_data.user_password = dt["user_password"].ToString();
                        doctor_get_data.first_name = dt["first_name"].ToString();
                        doctor_get_data.last_name = dt["last_name"].ToString();
                        doctor_get_data.phone = dt["phone"].ToString();
                        doctor_get_data.doctor_adress = dt["Doctor_adress"].ToString();
                        doctor_get_data.doctor_speciality = dt["Doctor_specialisty"].ToString();
                        doctor_get_data.doctor_affiliation = dt["Doctor_affiliation"].ToString();
                        doctor_get_data.doctor_rate = dt["Doctor_rate"].ToString();

                    }



                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
                connect.Close();
            }
            return "NO";
        }
    }
}
        #endregion



//        #region saving the logged in user

//        public static doctor doctor_get_data = new doctor();
//        public static patient patient_get_data = new patient();
//        public void get_logged_user_info()
//        {
//            bool found = false;
//            string myconnection = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;

//            SqlConnection conn = new SqlConnection(myconnection);

//            conn.Open();
//            MessageBox.Show("DP CONNETED");
//            try
//            {
//                string select_query = "SELECT patient_id,user_name,user_password,first_name,last_name,phone,user_role,patient_medical_status FROM PATIENT WHERE user_name='" + login_field.logged_in_username + "' ";

//                SqlCommand cmd = new SqlCommand(select_query, conn);

//                SqlDataReader dr = cmd.ExecuteReader();
//                if (dr.Read())
//                {
//                    found = true;
//                    patient_get_data.patient_id = int.Parse(dr["patient_id"].ToString());
//                    patient_get_data.user_name = dr["user_name"].ToString();
//                    patient_get_data.user_password = dr["user_password"].ToString();
//                    patient_get_data.first_name = dr["first_name"].ToString();
//                    patient_get_data.last_name = dr["last_name"].ToString();
//                    patient_get_data.phone = dr["phone"].ToString();
//                    patient_get_data.patient_health_description = dr["patient_medical_status"].ToString();


//                }

//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);

//            }
//            finally
//            {
//                conn.Close();
//            }

            
//            // check if doctor

          
//            conn.Open();
//            try
//            {
//                string select_query = "SELECT Doctor_id,user_name,user_password,first_name,last_name,phone,Doctor_adress,Doctor_speciality,Doctor_affiliation,Doctor_rate FROM DOCTOR WHERE user_name='" + login_field.logged_in_username + "' ";

//                SqlCommand cmd = new SqlCommand(select_query, conn);

//                SqlDataReader dr = cmd.ExecuteReader();
//                if (dr.Read() && found == false)
//                {
//                    found = true;
//                    doctor_get_data.doctor_id = int.Parse(dr["Doctor_id"].ToString());
//                    doctor_get_data.user_name = dr["user_name"].ToString();
//                    doctor_get_data.user_password = dr["user_password"].ToString();
//                    doctor_get_data.first_name = dr["first_name"].ToString();
//                    doctor_get_data.last_name = dr["last_name"].ToString();
//                    doctor_get_data.phone = dr["phone"].ToString();
//                    doctor_get_data.doctor_adress = dr["Doctor_adress"].ToString();
//                    doctor_get_data.doctor_speciality = dr["Doctor_speciality"].ToString();
//                    doctor_get_data.doctor_affiliation = dr["Doctor_affiliation"].ToString();
//                    doctor_get_data.doctor_rate = dr["Doctor_rate"].ToString();


//                }

//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);

//            }
//            finally
//            {
//                conn.Close();
//            }


//        }
//    }
//}
//        #endregion
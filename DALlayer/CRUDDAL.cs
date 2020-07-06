using businessLogicalLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace DALlayer
{
    public class CRUDDAL
    {
        public static string InsertData(CRUDBLL data)
        {
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["School"].ToString();
            SqlConnection Con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insertregistration";
            cmd.Parameters.Add("@firstName", SqlDbType.VarChar).Value = data.firstName;
            cmd.Parameters.Add("@lastName", SqlDbType.VarChar).Value = data.lastName;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = data.gender;
            cmd.Parameters.Add("@trainingType", SqlDbType.VarChar).Value = data.trainigType;

       
            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                return "Record inserted successfully";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
                Con.Dispose();
            }
        }
    }
}

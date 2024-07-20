using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;
namespace DataAccessLayer
{
	public class LoginDAL
	{
		private string connectionString = "Data Source=.;Initial Catalog=xpay;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public string EmialCheck(RegistrationDetails model)
		{
			SqlConnection con= new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection= con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "login_customer";
			cmd.Parameters.Clear();
			cmd.Parameters.AddWithValue("@email",model.CustomerEmail);
			cmd.Parameters.AddWithValue("@password",model.LoginPassword);
			SqlDataReader dr= cmd.ExecuteReader();
			if(dr.Read())
			{
				return dr["customer_fname"].ToString()+"." + dr["customer_lname"].ToString();
			}
			else
			{
				return "false";
			}
			con.Close();
		}
	}
}

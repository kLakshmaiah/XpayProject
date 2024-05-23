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
		private string connectionString = "Data Source=DESKTOP-5877V5N;Initial Catalog=xpay;Persist Security Info=True;User ID=sa;Password=1234567890";
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

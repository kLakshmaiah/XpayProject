using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Reflection.Emit;

namespace DataAccessLayer
{
	public class RegistrationDetailsDAL
	{
		private string connectionString = "Data Source=DESKTOP-5877V5N;Initial Catalog=xpay;Persist Security Info=True;User ID=sa;Password=1234567890";
		
		//save the registration Details
		public bool RegistrationSave(RegistrationDetails model)
		{
			SqlCommand cd = new SqlCommand();
			SqlConnection con = new SqlConnection(connectionString);
			try
			{
				cd.Connection = con;
				con.Open();
				cd.CommandText = "customer_data_insert";
				cd.Parameters.Clear();
				cd.CommandType = CommandType.StoredProcedure;
				cd.Parameters.AddWithValue("@customer_fname", model.CustomerFname);
				cd.Parameters.AddWithValue("@customer_lname",model.CustomerLname);
				cd.Parameters.AddWithValue("@customer_mobile",model.CustomerMobile);
				cd.Parameters.AddWithValue("@customer_email",model.CustomerEmail);
				cd.Parameters.AddWithValue("@login_password",model.LoginPassword);
				cd.Parameters.AddWithValue("@customer_address",model.CustomerAddress);
				cd.Parameters.AddWithValue("@security_questions_Code",model.SecurityQuestionsCode);
				cd.Parameters.AddWithValue("@security_answer_code",model.SecurityAnswerCode);
				cd.Parameters.AddWithValue("@account_no",model.AccountNo);
				if (cd.ExecuteNonQuery() > 0)
				{
					return true ;
				}
			}
			
			finally
			{
				con.Close();
			}
			return false;
		}

		// check the email is exist or not in the registration form 
		public bool CheckEmail(string email) 
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cd = new SqlCommand();
			try
			{
				cd.Connection = con;
				con.Open();
				cd.Parameters.Clear();
				cd.CommandText = "customer_Email_read";
				cd.CommandType = CommandType.StoredProcedure;
				cd.Parameters.AddWithValue("@customer_email", email);
				SqlDataReader dr = cd.ExecuteReader();
				if (dr.Read())
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			finally
			{
				con.Close();
			}
		}

		//password change form email is exist and return the email and security question and security answer 
		public string PassWordChange(string email)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cd = new SqlCommand();
			cd.Connection = con;
			con.Open();
			cd.Parameters.Clear();
			cd.CommandText = "securityquestions_answer_read";
			cd.CommandType = CommandType.StoredProcedure;
			cd.Parameters.AddWithValue("@email", email);
			SqlDataReader dr= cd.ExecuteReader();
			if (dr.Read())
			{
				return dr["name"].ToString()+","+dr["security_answer_code"].ToString();
			}
			else
			{
				return "false";
			}
			con.Close();
		}

		//password change form and update password
		public bool SavePassWordChange(RegistrationDetails model)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cd = new SqlCommand();
			cd.Connection = con;
			con.Open();
			cd.Parameters.Clear();
			cd.CommandText = "password_update_customer";
			cd.CommandType = CommandType.StoredProcedure;
			cd.Parameters.AddWithValue("@email", model.CustomerEmail);
			cd.Parameters.AddWithValue("@newpasword", model.LoginPassword);
			if (cd.ExecuteNonQuery()>0)
			{
				return true;
			}
			else
			{
				return false;
			}
			con.Close();
		}
	}
}

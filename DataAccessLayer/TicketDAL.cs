using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace DataAccessLayer
{
	public class TicketDAL
	{
		private string connectionString = "Data Source=.;Initial Catalog=xpay;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public string SaveTicketDetails(TicketDetails model)
		{
			SqlConnection con= new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection= con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ticket_details_save";
			cmd.Parameters.Clear();
			cmd.Parameters.AddWithValue("@name",model.Name);
			cmd.Parameters.AddWithValue("@email",model.Email);
			cmd.Parameters.AddWithValue("@mobile",model.MobileNumber);
			cmd.Parameters.AddWithValue("@problem", model.Problem);
			cmd.Parameters.AddWithValue("@description", model.Description);
			cmd.Parameters.Add("@ticket_id", SqlDbType.NVarChar,100).Direction=ParameterDirection.Output;
			if(cmd.ExecuteNonQuery()>0)
			return cmd.Parameters["@ticket_id"].Value.ToString();
			else
				return "false";
		}

		//calling to ticketdetailsform
		public TicketDetaislCollection CollectTicketDetails(string statusselected)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ticket_details_read";
			if(statusselected != null && statusselected != "")
			{
				cmd.Parameters.AddWithValue("@resolution", statusselected);
			}
			else
			{
				cmd.Parameters.AddWithValue("@resolution", DBNull.Value);
				cmd.Parameters["@resolution"].SqlDbType=SqlDbType.NVarChar;
			}
			SqlDataReader dr=cmd.ExecuteReader();
			return ReadAllTicketDetails(dr);
		}

		private TicketDetaislCollection ReadAllTicketDetails(SqlDataReader dr)
		{
			TicketDetaislCollection ticket_collection= new TicketDetaislCollection();
			
			while (dr.Read())
			{
				TicketDetails model = new TicketDetails();
				model.Id = dr["ticket_number"].ToString();
				model.Name = dr["name"].ToString();
				model.Email = dr["email"].ToString();
				model.MobileNumber = dr["mobile"].ToString();
				model.Problem = dr["problem"].ToString() ;
				model.Description= dr["description"].ToString();
				model.IntialStatus= dr["ticket_status"].ToString();
                model.StatusCode = dr["ticket_status"].ToString();
                model.CreatedOn = Convert.ToDateTime(dr["created_on"]);
				model.UpdatedOn= Convert.ToDateTime(dr["updated_on"]);
                model.AssignedTo = dr["username"].ToString();
                model.userId= Convert.ToInt64(dr["userId"]);
				model.ResolvedOn = Convert.ToDateTime(dr["resolved_on"]);
				model.Resolution = dr["resolution"].ToString();
				ticket_collection.Add(model);
			}
			return ticket_collection;
		}
		//all Ticket numbers assogned to UpdateTicketStatus form 
		public TicketDetaislCollection ReadTicketNumbers()
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ticket_numbers";
			SqlDataReader dr=cmd.ExecuteReader();
			var ticket_data = AssignAllticketDetails(dr);
			return ticket_data;
		}
	    private TicketDetaislCollection AssignAllticketDetails(SqlDataReader dr)//in this case i used List
		{
			TicketDetaislCollection ticketDetails= new TicketDetaislCollection();
			while(dr.Read())
			{
				TicketDetails model= new TicketDetails();
				model.StatusCode = dr["ticket_number"].ToString();
				ticketDetails.Add(model);
			}
			return ticketDetails;
		}

		//read the employee names assigned the task
		public TicketDetaislCollection CustomerNames()
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "read_customer_names";
			SqlDataReader dr = cmd.ExecuteReader();
			var customernames = ReadAllCustomerNames(dr);
			return customernames;
			//return ticketDetaislCollection;
		}

		private TicketDetaislCollection ReadAllCustomerNames(SqlDataReader dr)
		{
			TicketDetaislCollection ticketDetaislCollection = new TicketDetaislCollection();
			while (dr.Read())
			{
				TicketDetails model = new TicketDetails();
				model.Id = dr["id"].ToString();
				model.Name =dr["userName"].ToString();
				ticketDetaislCollection.Add(model);
			}
			return ticketDetaislCollection;
		}

		//assign the data to updateTicketStatus Data
		public TicketDetails TicketDataToUpTcktStatus(string tktcode)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@ticket_code", tktcode);
			cmd.CommandText = "ticket_id_details_read";
			SqlDataReader dr = cmd.ExecuteReader();
			var model = new TicketDetails();
			if (dr.Read())
			{
				model.Name = dr["Name"].ToString();
				model.Email = dr["email"].ToString();
				model.MobileNumber = dr["mobile"].ToString();
				model.Problem = dr["problem"].ToString();
				model.Description = dr["Description"].ToString();
				model.Id = dr["id"].ToString();
			}
			return model;

		}
		

		public List<string> StatusNamesRead()
		{
			List<string> statusnames = new List<string>();
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "status_names_read";
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				statusnames.Add(dr["Name"].ToString());
			}
			return statusnames;
		}

		public bool UpdateTicketMaster(TicketDetails model)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "update_ticket_master_Details";
			cmd.Parameters.Clear();
			cmd.Parameters.AddWithValue("@assignedid", Convert.ToInt32(model.Id));
			cmd.Parameters.AddWithValue("@ticket_number", model.StatusCode);
			if (model.Resolution != "" && model.Resolution!=null)
			{
					cmd.Parameters.AddWithValue("@resolution", model.Resolution);
			}
			 if(model.Description != "" && model.Resolution != null) 
			{
				cmd.Parameters.AddWithValue("@remarks", model.Description);
			}
			if (cmd.ExecuteNonQuery() > 0)
				return true;
			else
				return false;
		}


		public TicketDetails  ResolvedStatus(string tcktno)
		{
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "select_resolution";
			cmd.Parameters.AddWithValue("@tciket_number", tcktno);
			SqlDataReader dr = cmd.ExecuteReader();
			TicketDetails model = new TicketDetails();
			if (dr.Read())
			{
				    model.Id= dr["id"].ToString();
					model.Name = dr["customer_lname"].ToString();//user name
					model.Resolution = dr["resolution"].ToString();//resolution	
			}
			return model;
		}


		public Dictionary<string,int> TicketCount()
		{
			Dictionary<string,int> count=new Dictionary<string, int>();
			SqlConnection con = new SqlConnection(connectionString);
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "count_tickets";
			SqlDataReader dr= cmd.ExecuteReader();
			if (dr.Read())
			{
				count.Add("intialized",Convert.ToInt32(dr["intialized"]));
				count.Add("assigned", Convert.ToInt32(dr["assigned"]));
				count.Add("Inprogress", Convert.ToInt32(dr["Inprogress"]));
				count.Add("resolved", Convert.ToInt32(dr["resolved"]));
				count.Add("reopen", Convert.ToInt32(dr["reopen"]));
				count.Add("closed", Convert.ToInt32(dr["closed"]));
			}
			return count;
		}

	}
}

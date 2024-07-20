using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
	public class SecurityQuestionsDAL
	{
		private string _connectionString = "Data Source=.;Initial Catalog=xpay;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
		public Security_Questions_Collections GetAllQuestions()
		{
			SqlConnection conn = new SqlConnection(_connectionString);
			conn.Open();
			SqlCommand comm = conn.CreateCommand();
			comm.CommandType = CommandType.StoredProcedure;
			comm.CommandText = "Security_Questions_Read";
			SqlDataReader reader= comm.ExecuteReader();
		    var collection =Assignreadertocollection(reader);
			conn.Close();
			return collection;
		}
		private Security_Questions_Collections Assignreadertocollection(SqlDataReader reader)
		{
			var coll = new Security_Questions_Collections();
			while(reader.Read())
			{
				Security_Questions model=new Security_Questions();
				model.Id = Convert.ToInt32(reader["id"].ToString());
				model.Name = reader["name"].ToString();
				model.Code= reader["code"].ToString();
				model.IsActive = Convert.ToBoolean(reader["is_active"].ToString());
				coll.Add(model);
			}
			return coll;

		}
	}
}

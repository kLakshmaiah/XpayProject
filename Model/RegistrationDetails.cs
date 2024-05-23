using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class RegistrationDetails
	{
		public int Id { get; set; }
		public string CustomerFname { get; set; }
		public string CustomerLname { get; set; }
		public string CustomerMobile { get; set; }
		public string CustomerEmail { get; set; }
		public string LoginPassword { get; set; }
		public string CustomerAddress { get; set; }
		public bool IsBlocked { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }
		public string SecurityQuestionsCode { get; set; }
		public string SecurityAnswerCode { get; set; }
		public string AccountNo { get; set; }
	}
}

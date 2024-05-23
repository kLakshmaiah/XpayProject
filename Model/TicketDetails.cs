using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class TicketDetails
	{
	   public string Id { get; set; }
	   public string Name{get;set;}
	   public string Email { get; set; }
	   public string MobileNumber { get; set; }
	   public string Problem { get; set; }
	   public string Description { get; set; }
	   public string StatusCode { get; set; }
	   public DateTime CreatedOn { get; set; }
	   public DateTime UpdatedOn { get; set;}
	   public long userId { get; set; }
	   public DateTime ResolvedOn { get; set; }
       public string Resolution { get; set; }
	}
}

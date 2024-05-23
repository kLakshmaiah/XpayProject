using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class TicketDetaislCollection:CollectionBase
	{
		public TicketDetails this[int index]
		{
			get
			{
				//note it doubt down.
				return (TicketDetails)this.List[index];//typec casting
			}
			set
			{
				this.List[index] = value;
			}
		}
		public int IndexOf(TicketDetails customerItem)
		{
			if (customerItem != null)
			{
				return base.List.IndexOf(customerItem);
			}
			return -1;
		}

		public int Add(TicketDetails customerItem)
		{
			if (customerItem != null)
			{
				return this.List.Add(customerItem);
			}
			return -1;
		}

		public void Remove(TicketDetails customerItem)
		{
			this.InnerList.Remove(customerItem);
		}

		public void AddRange(TicketDetaislCollection collection)
		{
			if (collection != null)
			{
				this.InnerList.AddRange(collection);
			}
		}

		public void Insert(int index, TicketDetails customerItem)
		{
			if (index <= List.Count && customerItem != null)
			{
				this.List.Insert(index, customerItem);
			}
		}

		public bool Contains(TicketDetails customerItem)
		{
			return this.List.Contains(customerItem);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
	public class Security_Questions_Collections:CollectionBase
	{

		public Security_Questions this[int index]
		{
			get
			{
				//note it doubt down.
				return (Security_Questions)this.List[index];//typec casting
			}
			set
			{
				this.List[index] = value;
			}
		}
		public int IndexOf(Security_Questions customerItem)
		{
			if (customerItem != null)
			{
				return base.List.IndexOf(customerItem);
			}
			return -1;
		}
		
		public int Add(Security_Questions customerItem)
		{
			if (customerItem != null)
			{
				return this.List.Add(customerItem);
			}
			return -1;
		}

		public void Remove(Security_Questions customerItem)
		{   
			this.InnerList.Remove(customerItem);
		}

		public void AddRange(Security_Questions_Collections collection)
		{
			if (collection != null)
			{
				this.InnerList.AddRange(collection);
			}
		}

		public void Insert(int index, Security_Questions customerItem)
		{
			if (index <= List.Count && customerItem != null)
			{
				this.List.Insert(index, customerItem);
			}
		}

		public bool Contains(Security_Questions customerItem)
		{
			return this.List.Contains(customerItem);
		}
	}
}

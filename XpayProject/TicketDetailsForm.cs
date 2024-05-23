using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Model;

namespace XpayProject
{
	public partial class TicketDetailsForm : Form
	{
		public TicketDetailsForm()
		{
			InitializeComponent();
		}
		bool flag = false;
		private void DashBoard_Load(object sender, EventArgs e)
		{
			var ticketDAL = new TicketDAL();
			var ticketDetails = ticketDAL.CollectTicketDetails(null);
			dataGridView1.DataSource = ticketDetails;
			var statusnames = ticketDAL.StatusNamesRead();
			statusDetails.Items.Add("All");
			var i = 0;
			while (i < statusnames.Count)
			{
				statusDetails.Items.Add(statusnames[i]);
				i++;
			}
			statusDetails.SelectedItem="All";
			flag = true;
		}


		private void statusDetails_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (flag)
			{
				if (statusDetails.SelectedItem.ToString()=="All")
				{
					var ticketDAL = new TicketDAL();
					var ticketDetails = ticketDAL.CollectTicketDetails(null);
					dataGridView1.DataSource = ticketDetails;
				}
				else
				{
					var ticketDAL = new TicketDAL();
					var ticketDetails = ticketDAL.CollectTicketDetails(statusDetails.SelectedItem.ToString());
					dataGridView1.DataSource = ticketDetails;
				}
				
			}
			
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			DashBoardPage dp = new DashBoardPage();
			dp.Tag = this.Tag;
			this.Tag = "";
			dp.Show();
		}
	}
}

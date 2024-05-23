using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpayProject
{
	public partial class DashBoardPage : Form
	{
		public DashBoardPage()
		{
			InitializeComponent();
		}

		private void logoutBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			var lgn= new XpayLogin();
			   lgn.Show();
		}

		private void DashBoardPage_Load(object sender, EventArgs e)
		{
			if (this.Tag !=null)
			{
				loginSuceesLb.Text += this.Tag.ToString();
				//this.Tag = "";
			}
		}

		private void raiseTicketBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			var raiseTicket = new RaiseTickeForm();
			raiseTicket.Tag= this.Tag;
			raiseTicket.Show();
		}

		private void raisedTickets_Click(object sender, EventArgs e)
		{
			this.Hide();
			var td = new TicketDetailsForm();
			td.Tag= this.Tag;
			td.Show();
		}

		private void updateTicketStatus_Click(object sender, EventArgs e)
		{
			this.Hide();
			var updateTicketStatus = new UpdateTicketStatus();
			updateTicketStatus.Tag= this.Tag;
			updateTicketStatus.Show();
		}

		private void ticketAnalysisBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			var ta = new TicketAnalysis();
			ta.Tag= this.Tag;
			ta.Show();
		}
	}
}

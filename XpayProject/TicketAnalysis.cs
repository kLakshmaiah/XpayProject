using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace XpayProject
{
	public partial class TicketAnalysis : Form
	{
		public TicketAnalysis()
		{
			InitializeComponent();
		}

		private void TicketAnalysis_Load(object sender, EventArgs e)
		{
			var tdal= new TicketDAL();
			var  count= tdal.TicketCount();
			if(count.Count>0)
			{
				intializeLb.Text+=count["intialized"];
				assignedLb.Text += count["assigned"];
				unAssignedLb.Text += count["Inprogress"];
				resolvedLb.Text += count["resolved"];
				reOpenLb.Text += count["reopen"];
				closedLb.Text += count["closed"];
				chart1.Series["countTicket"].Points.AddXY("intialized", count["intialized"]);
				chart1.Series["countTicket"].Points.AddXY("assigned", count["assigned"]);
				chart1.Series["countTicket"].Points.AddXY("Inprogress", count["Inprogress"]);
				chart1.Series["countTicket"].Points.AddXY("resolved", count["resolved"]);
				chart1.Series["countTicket"].Points.AddXY("reopen", count["reopen"]);
				chart1.Series["countTicket"].Points.AddXY("closed", count["closed"]);
			}
			
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			DashBoardPage dp= new DashBoardPage();
			 dp.Tag= this.Tag;
			this.Tag="";
			dp.Show();
		}
	}
}

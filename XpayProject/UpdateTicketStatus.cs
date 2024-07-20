using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XpayProject
{
	public partial class UpdateTicketStatus : Form
	{
		public UpdateTicketStatus()
		{
			InitializeComponent();
		}

		string userid;

		private void UpdateTicketStatus_Load(object sender, EventArgs e)
		{
			var ticketDAL= new TicketDAL();
			var ticketDetails = ticketDAL.ReadTicketNumbers();
		    var status_names=ticketDAL.StatusNamesRead();
            var i = 0;
			ticketIdCb.Text="--select ticket-----";
			while (i<ticketDetails.Count)
			{
				ticketIdCb.Items.Add(ticketDetails[i].StatusCode.ToString());
				i++;
			}
			 i = 0;
			while (i < status_names.Count)
			{
				updateStatusCb.Items.Add(status_names[i].ToString());
				i++;
			}
			updateStatusCb.Text = "--select status-----";
			assignedLb.Visible=assignedCb.Visible=remarksLb.Visible=remarksTb.Visible=assignedUserNameLb.Visible=currentStatus.Visible= false;
		}

		//form validation
		private bool FormValidation()
		{
			bool status = true;
			if (ticketIdCb.SelectedItem == "" || ticketIdCb.SelectedItem == null)
			{
				MessageBox.Show("please Select Yoru Ticket", "TicketError", MessageBoxButtons.OK, MessageBoxIcon.Error);
				status = false;	
				return status;
			}
			 else if(updateStatusCb.SelectedItem == "" || updateStatusCb.SelectedItem == null)
			{
				MessageBox.Show("please Select Yoru Status", "StatusError", MessageBoxButtons.OK, MessageBoxIcon.Error);
				status = false;
				return status;
			}
			 else if(assignedCb.Visible)
			{
				if (assignedCb.Text== "---select Assigned Employee---" || assignedCb.Text == null)
				{
					MessageBox.Show("Assigned is Not Empty Select Any one of Them", "AssignedError", MessageBoxButtons.OK, MessageBoxIcon.Error);
					status = false;
					return status;
				}
			}
			else if (remarksTb.Visible)
			{
				if (remarksTb.Text.Trim().Length > 0)
				{
					Regex remarksValidation = new Regex(@"^[a-zA-Z ]+$");
					if (!remarksValidation.IsMatch(remarksTb.Text))
					{
						MessageBox.Show("Enter Alphabets Values Only", "RemarksError", MessageBoxButtons.OK,
						 MessageBoxIcon.Error);
						status = false;
						return status;
					}

				}
				else
				{
					MessageBox.Show("Enter Your Remarks", "RemarksError", MessageBoxButtons.OK,
						 MessageBoxIcon.Error);
					status = false;
					return status;
				}
			}
			return status;
		}

		//select change event
		private void ticketIdCb_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ticketIdCb.SelectedItem != "" && ticketIdCb.SelectedItem != null)
			{
				var ticketDAL = new TicketDAL();
				var  model = ticketDAL.TicketDataToUpTcktStatus(ticketIdCb.SelectedItem.ToString());
				if (model.Name != "" && model.Name != null)
				{
					userid = model.Id;
					nameTb.Text = model.Name;
					emailTb.Text = model.Email;
					mobileTb.Text = model.MobileNumber;
					problemTb.Text = model.Problem;
					descriptionTb.Text = model.Description;
				}
				else
				{
					nameTb.Text = emailTb.Text = mobileTb.Text = problemTb.Text = descriptionTb.Text = "";
					ticketIdCb.SelectedIndex = 0;
					ticketIdCb.Text = "--select ticket-----";
					if (MessageBox.Show("There is No Ticket  Available Are You Going To DashBoard", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
					{
						this.Hide();
						DashBoardPage dp = new DashBoardPage();
						dp.Show();
						return;
					}

				}
			}
			if (ticketIdCb.SelectedItem != "" && ticketIdCb.SelectedItem != null && updateStatusCb.SelectedItem != "" && updateStatusCb.SelectedItem != null)
			{
				if(updateStatusCb.SelectedItem.ToString().Equals("assigned",StringComparison.CurrentCultureIgnoreCase))
				{
				    
					remarksLb.Visible = remarksTb.Visible = false;
					assignedUserNameLb.Text=currentStatus.Text = "";
					assignedLb.Visible = assignedCb.Visible = true;
					var ticketDAL = new TicketDAL();
					var customernames = ticketDAL.CustomerNames();
					assignedCb.DataSource = customernames;
					assignedCb.DisplayMember = "Name";
					assignedCb.ValueMember = "Id";
					assignedCb.Text = "---select Assigned Employee---";
				}
				else if(updateStatusCb.SelectedItem.ToString().Equals("resolved",StringComparison.CurrentCultureIgnoreCase))
				{
					assignedLb.Visible = assignedCb.Visible = false;
					remarksLb.Visible=remarksTb.Visible = true;
					assignedUserNameLb.Visible = currentStatus.Visible = true;
					try
					{
						if (ticketIdCb.Text.Trim().Length > 0)
						{
							var tdl = new TicketDAL();
							var resolution_details = tdl.ResolvedStatus(ticketIdCb.SelectedItem.ToString());
							assignedUserNameLb.Text += resolution_details.Name.ToString();
							currentStatus.Text += resolution_details.Resolution.ToString();
							userid = resolution_details.Id;
						}
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
					
				}
				else
				{
					assignedLb.Visible = assignedCb.Visible = false;
					remarksLb.Visible = remarksTb.Visible = false;
				}
				
			}
			else
			{
				assignedLb.Visible = assignedCb.Visible = false;
			}
				
		}

		private void submitBtn_Click(object sender, EventArgs e)
		{
			bool status=FormValidation();
			if (status)
			{
				var model	= new TicketDetails();
				if(assignedCb.SelectedValue!="" && assignedCb.SelectedValue != null)
				{
					model.Id = assignedCb.SelectedValue.ToString();// assigned candiate id
				}
				else
				{
					model.Id = userid;
					if(model.Id == "" || model.Id == null || Convert.ToInt32(model.Id) == 0)
					{
						MessageBox.Show("This Ticket Is Not Assigned To Anyone Please Assigned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				model.StatusCode = ticketIdCb.SelectedItem.ToString();//ticket Number
				model.Resolution= updateStatusCb.SelectedItem.ToString(); //resolution
				model.Description = remarksTb.Text;//remarks column..
				var ob = new TicketDAL();
				var success= ob.UpdateTicketMaster(model);
				if (success)
				{
					MessageBox.Show("SuccessFully Update Ticket", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					backBtn.PerformClick();
				}
				else
				{
					MessageBox.Show("Ticket is Not Updated", "Conformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			DashBoardPage dp = new DashBoardPage();
			dp.Tag = this.Tag;
			this.Tag ="";
			dp.Show();
		}

	
	}
}

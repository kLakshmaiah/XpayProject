using DataAccessLayer;
using Model;
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
using Model;

namespace XpayProject
{
	public partial class RaiseTickeForm : Form
	{
		public RaiseTickeForm()
		{
			InitializeComponent();
		}

		public bool FormValidating()
		{
			bool isvalid = true;
			//firstname validation
			if (nameTb.Text.Trim().Length > 0)
			{
				Regex fstrNameValidation = new Regex(@"^[a-zA-Z]+$");
				if (!fstrNameValidation.IsMatch(nameTb.Text))
				{
					MessageBox.Show("Name Accepts Alphabets Values Only", "NameTbError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}

			}
			else
			{
				MessageBox.Show("Enter Your Name", "NameError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//emial validation
			if (emailTb.Text.Trim().Length > 0)
			{
				bool isEmail = Regex.IsMatch(emailTb.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
				if (!isEmail)
				{
					MessageBox.Show("Enter a valid email.", "EmailError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
			}
			else
			{
				MessageBox.Show("Enter Your EmailId", "EmailIdError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}

			//mobilenumber validation
			if (mobileTb.Text.Trim().Length > 0)
			{
				Regex mobileValidation = new Regex(@"^[6-9]\d{9}$");
				if (!mobileValidation.IsMatch(mobileTb.Text))
				{
					MessageBox.Show("MobileNumber Must Be 10 digits and starting number b/w 6-9", "MobileNumber", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
			}
			else
			{
				MessageBox.Show("Enter Your MobileNumber", "MobileNumber", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//problem validation
			if (problemTb.Text.Trim().Length > 0)
			{
				Regex problemTbValidation = new Regex(@"^[a-zA-Z ]+$");
				if (!problemTbValidation.IsMatch(problemTb.Text))
				{
					MessageBox.Show("Problem accepts  Alphabets  Only", "problemError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}

			}
			else
			{
				MessageBox.Show("Enter Your problem", "problemError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//Description validation
			if (descriptionTb.Text.Trim().Length > 0)
			{
				Regex descriptionTbValidation = new Regex(@"^[a-zA-Z ]+$");
				if (!descriptionTbValidation.IsMatch(descriptionTb.Text))
				{
					MessageBox.Show(" description accepts  Alphabets  Only", "descriptionTbError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}

			}
			else
			{
				MessageBox.Show("Enter Your Description", "descriptionError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			return isvalid;
		}
		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			DashBoardPage dp = new DashBoardPage();
			dp.Tag= this.Tag;
			this.Tag = "";
			dp.Show();
		}
		private void raiseTckt_Click(object sender, EventArgs e)
		{
			bool status = FormValidating();
			if (status)
			{
                var model= new TicketDetails();
				model.Name=nameTb.Text;
				model.Email=emailTb.Text;
				model.MobileNumber=mobileTb.Text;
				model.Problem=problemTb.Text;
				model.Description=descriptionTb.Text;
				var tdal= new TicketDAL();
				var ticket_number= tdal.SaveTicketDetails(model);
				if (ticket_number!="false")
				{
					if (MessageBox.Show($"Thank You Raising Ticket \n Your Ticket Number is {ticket_number}", "TicketSuccess", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
					{
						backBtn.PerformClick();
					}
				}
				else
				{
					if (MessageBox.Show("ticket raising is fail", "TicketError", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
					{
						backBtn.PerformClick();
					}
				}
				
				
			}

		}
	}
}

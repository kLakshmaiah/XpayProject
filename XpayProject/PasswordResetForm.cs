using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
	public partial class PasswordResetForm : Form
	{
		public PasswordResetForm()
		{
			InitializeComponent();
		}
		string answer = "";
		private void PasswordResetForm_Load(object sender, EventArgs e)
		{
			selectSecurityQsnsLb.Enabled=newPaswrdTb.Enabled=securityAnswerTb.Enabled=submitBtn.Enabled=false;
		}
		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			XpayLogin xpLgn= new XpayLogin();
			xpLgn.Show();
		}
		private void submitBtn_Click(object sender, EventArgs e)
		{
			bool status = false;
			if (securityAnswerTb.Text.Trim().Length > 0)
			{
				if (answer == securityAnswerTb.Text)
				{
					newPaswrdTb.Enabled = submitBtn.Enabled = true;
					securityAnswerTb.Enabled = false;
					status = true;
				}
				else
				{
					MessageBox.Show("Your Answer Is Not Macthed\n Enter a Valid Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			if (status)
			{
				if (newPaswrdTb.Text.Trim().Length > 0)
				{
					bool Status = Regex.IsMatch(newPaswrdTb.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
					if (!Status)
					{
						MessageBox.Show("Password must be between 6 and 20 characters and contain one " +
							"uppercase letter, one lowercase letter, one digit and one special character.", "password", MessageBoxButtons.OK,
						 MessageBoxIcon.Error);
						return;
					}
					else
					{
						var model = new RegistrationDetails();
						model.CustomerEmail = emailTb.Text;
						model.LoginPassword = newPaswrdTb.Text;
						var rgs = new RegistrationDetailsDAL();
						bool passwordstatus = rgs.SavePassWordChange(model);
						if (passwordstatus)
						{
							MessageBox.Show("Your Password is Update", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							backBtn.PerformClick();
						}
						else
						{
							MessageBox.Show("Your Password is Not Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			
			}

		}

		private void proceedbtn_Click(object sender, EventArgs e)
		{
			if (emailTb.Text.Trim().Length > 0)
			{
				bool isEmail = Regex.IsMatch(emailTb.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
				if (!isEmail)
				{
					MessageBox.Show("Entered string is not in a valid email format.", "EmailError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					return;
				}
				else
				{
					var customer = new RegistrationDetailsDAL();
					string qusetion= customer.PassWordChange(emailTb.Text);
					if (qusetion == "false")
					{
						MessageBox.Show("invalid a Valid email Address");
						emailTb.Text = "";
						return;
					}
					else
					{
						emailTb.Enabled = false;
						int lastindex = qusetion.IndexOf(",");
						answer = qusetion.Substring(lastindex);
						answer = answer.Remove(0, 1);
						qusetion = qusetion.Remove(lastindex);
						securityAnswerTb.Enabled =submitBtn.Enabled=newPaswrdTb.Enabled= true;
						selectSecurityQsnsLb.Items.Clear();
						selectSecurityQsnsLb.Items.Add(qusetion);
						if (selectSecurityQsnsLb.Items.Count > 0)
						{
							selectSecurityQsnsLb.Enabled = false;
							securityAnswerTb.Focus();
						}
					}
					
				}
			}
			else
			{
				MessageBox.Show("Enter valid Email", "Error", MessageBoxButtons.OK,
				 MessageBoxIcon.Error);
				return;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using Model;
using DataAccessLayer;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace XpayProject
{
	public partial class XpayLogin : Form
	{
		public XpayLogin()
		{
			InitializeComponent();
		}
		private void registerBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			XpayRegister xpyRgs= new XpayRegister();
			xpyRgs.Show();
		}

		private void forgotPswrdBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			PasswordResetForm pswrdrest=new PasswordResetForm();
			pswrdrest.Show();
		}

		private bool FormValidation()
		{
			bool isvalid=true;
			//email validation
			if(emailTb.Text.Trim().Length >0)
			{
				bool status = Regex.IsMatch(emailTb.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
				if (!status)
				{
					MessageBox.Show("please Enter a valid email .", "EmailError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}	
			}
			else
			{
				MessageBox.Show("Please Enter EmailId and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//password Validation
			if (passwordTb.Text.Trim().Length>0)
			{
				bool Status = Regex.IsMatch(passwordTb.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
				if (!Status)
				{
					MessageBox.Show("Invalid Password", "password Error", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
			}
			else
			{
				MessageBox.Show("Please Entet Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
	       return isvalid;
		}

		private void proceedBtn_Click(object sender, EventArgs e)
		{
			bool isvalid=FormValidation();
			if (isvalid)
			{
				//calling the database Methods
				RegistrationDetails model = new RegistrationDetails();
				model.CustomerEmail = emailTb.Text;
				model.LoginPassword = passwordTb.Text;
				var lgin = new LoginDAL();
				string loginstatus = lgin.EmialCheck(model);
				if (loginstatus!= "false")
				{
					this.Hide();
					DashBoardPage dpage = new DashBoardPage();
					dpage.Tag = loginstatus;
					dpage.Show();
				}
				else
				{
					MessageBox.Show("Invalid Email-Id or Password", "LoginError", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
		}
	}
}

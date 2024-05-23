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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using DataAccessLayer;
using Model;
using System.Drawing.Printing;
using System.Collections;

namespace XpayProject
{
	public partial class XpayRegister : Form
	{
		public XpayRegister()
		{
			InitializeComponent();
		}
		private void XpayRegister_Load(object sender, EventArgs e)
		{
			SecurityQuestionsDAL questions_coll = new SecurityQuestionsDAL();	
			var qusetionReader = questions_coll.GetAllQuestions();
			selectSecurityQsnCbx.DataSource = qusetionReader;
			selectSecurityQsnCbx.DisplayMember = "Name";
			selectSecurityQsnCbx.ValueMember = "Code";
			firstNameTb.Focus();
		}
		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			XpayLogin xpyLgn = new XpayLogin();
			xpyLgn.Show();
		}

		private bool Form_Validating()
		{
			bool isvalid = true;
			//firstname validation
			if (firstNameTb.Text.Trim().Length>0)
			{
				Regex fstrNameValidation = new Regex(@"^[a-zA-Z]+$");
				if (!fstrNameValidation.IsMatch(firstNameTb.Text))
				{
					MessageBox.Show("Enter Alphabets Values Only", "firstNameTbError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}

			}
			else
			{
				MessageBox.Show("Enter Your FirstName", "firstNameTbError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//lastname validation
			if (lastNameTb.Text.Trim().Length > 0)
			{
				Regex fstrNameValidation = new Regex(@"^[a-zA-Z]+$");
				if (!fstrNameValidation.IsMatch(firstNameTb.Text))
				{
					MessageBox.Show("Enter Alphabets  Only", "LastNameError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}

			}
			else
			{
				MessageBox.Show("Enter Your LastName", "LastNameError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//mobilevalidation
			if (mobileTb.Text.Trim().Length>0)
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
			//email validation
			if (emailTb.Text.Trim().Length>0)
			{
				bool isEmail = Regex.IsMatch(emailTb.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
				if (!isEmail)
				{
					MessageBox.Show("Enter a valid email.", "EmailError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
				else
				{
					RegistrationDetailsDAL ob = new RegistrationDetailsDAL();
					bool status = ob.CheckEmail(emailTb.Text);
					if (status)
					{
						if (MessageBox.Show("This Email Is already Register,Enter another Email-Id", "EmailIdError", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
						{
							isvalid = false;
							return isvalid;
						}

					}
				}
				
			}
			else
			{
				MessageBox.Show("Enter Your EmailId", "EmailIdError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//account validation
			if (accountTb.Text.Trim().Length>0)
			{
				Regex accountValidation = new Regex(@"^\d{9,18}", RegexOptions.IgnoreCase);
				if (!accountValidation.IsMatch(accountTb.Text))
				{
					MessageBox.Show("Enter an AccountNumber Between 9-18 Digits Only.", "AccountNumberError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
			}
			else
			{
				MessageBox.Show("Enter Your AccountNumber", "AccountNumberError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//selectQuestions Validation
			if(selectSecurityQsnCbx.SelectedValue.ToString()== "Sq001")
			{
				MessageBox.Show("select your Question", "SelectQuestionError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			//security Question Answers validation
			if (securityAnsTb.Text.Trim().Length == 0)
			{
				MessageBox.Show("Enter Your SecurityAnswer", "SecurityAnswerError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			} 
			//password Validation
			if (passwordTb.Text.Trim().Length>0)
			{
				bool Status = Regex.IsMatch(passwordTb.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
				if (!Status)
				{
					MessageBox.Show("Password must be between 6 and 20 characters and contain one " +
						"uppercase letter, one lowercase letter, one digit and one special character.", "passwordError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
					isvalid = false;
					return isvalid;
				}
			}
			else
			{
				MessageBox.Show("Enter Your Password", "passwordError", MessageBoxButtons.OK,
					 MessageBoxIcon.Error);
				isvalid = false;
				return isvalid;
			}
			return isvalid;
		}

		private void registerBtn_Click(object sender, EventArgs e)
		{
			//calling the Formvalidation Method
			bool isvalid = Form_Validating();
			if (isvalid)
			{
				var model = new RegistrationDetails();
				model.CustomerFname = firstNameTb.Text;
				model.CustomerLname = lastNameTb.Text;
				model.CustomerMobile = mobileTb.Text;
				model.CustomerEmail = emailTb.Text;
				model.LoginPassword = passwordTb.Text;
				model.CustomerAddress = addressTb.Text;
				model.SecurityQuestionsCode = selectSecurityQsnCbx.SelectedValue.ToString();
				model.SecurityAnswerCode = securityAnsTb.Text;
				model.AccountNo = accountTb.Text;
				//calling the database 
				var rgs = new RegistrationDetailsDAL();
				bool status = rgs.RegistrationSave(model);
				if (status)
				{
					if (MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
					{
						firstNameTb.Text = lastNameTb.Text = mobileTb.Text = emailTb.Text = addressTb.Text
							= accountTb.Text = securityAnsTb.Text = passwordTb.Text = "";
					     backBtn.PerformClick();
					}
				}
				else
				{	
					MessageBox.Show("Registration Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}
	}
}

namespace XpayProject
{
	partial class XpayLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.xpayLb = new System.Windows.Forms.Label();
			this.regstrationLb = new System.Windows.Forms.Label();
			this.passwordTb = new System.Windows.Forms.TextBox();
			this.passwordLb = new System.Windows.Forms.Label();
			this.emailTb = new System.Windows.Forms.TextBox();
			this.emailLb = new System.Windows.Forms.Label();
			this.registerBtn = new System.Windows.Forms.Button();
			this.forgotPswrdBtn = new System.Windows.Forms.Button();
			this.proceedBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xpayLb
			// 
			this.xpayLb.AutoSize = true;
			this.xpayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xpayLb.Location = new System.Drawing.Point(99, 61);
			this.xpayLb.Name = "xpayLb";
			this.xpayLb.Size = new System.Drawing.Size(245, 37);
			this.xpayLb.TabIndex = 1;
			this.xpayLb.Text = "Xpay Life Bank";
			// 
			// regstrationLb
			// 
			this.regstrationLb.AutoSize = true;
			this.regstrationLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.regstrationLb.Location = new System.Drawing.Point(151, 110);
			this.regstrationLb.Name = "regstrationLb";
			this.regstrationLb.Size = new System.Drawing.Size(133, 31);
			this.regstrationLb.TabIndex = 2;
			this.regstrationLb.Text = "Welcome";
			// 
			// passwordTb
			// 
			this.passwordTb.Location = new System.Drawing.Point(157, 201);
			this.passwordTb.Name = "passwordTb";
			this.passwordTb.Size = new System.Drawing.Size(162, 20);
			this.passwordTb.TabIndex = 9;
			// 
			// passwordLb
			// 
			this.passwordLb.AutoSize = true;
			this.passwordLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLb.Location = new System.Drawing.Point(92, 204);
			this.passwordLb.Name = "passwordLb";
			this.passwordLb.Size = new System.Drawing.Size(56, 13);
			this.passwordLb.TabIndex = 8;
			this.passwordLb.Text = "Password:";
			// 
			// emailTb
			// 
			this.emailTb.Location = new System.Drawing.Point(157, 156);
			this.emailTb.Name = "emailTb";
			this.emailTb.Size = new System.Drawing.Size(162, 20);
			this.emailTb.TabIndex = 7;
			//this.emailTb.Validating += new System.ComponentModel.CancelEventHandler(this.FormValidation);
			// 
			// emailLb
			// 
			this.emailLb.AutoSize = true;
			this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLb.Location = new System.Drawing.Point(93, 159);
			this.emailLb.Name = "emailLb";
			this.emailLb.Size = new System.Drawing.Size(47, 13);
			this.emailLb.TabIndex = 6;
			this.emailLb.Text = "Email Id:";
			// 
			// registerBtn
			// 
			this.registerBtn.Location = new System.Drawing.Point(190, 237);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(75, 23);
			this.registerBtn.TabIndex = 22;
			this.registerBtn.Text = "Register";
			this.registerBtn.UseVisualStyleBackColor = true;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// forgotPswrdBtn
			// 
			this.forgotPswrdBtn.Location = new System.Drawing.Point(291, 237);
			this.forgotPswrdBtn.Name = "forgotPswrdBtn";
			this.forgotPswrdBtn.Size = new System.Drawing.Size(104, 23);
			this.forgotPswrdBtn.TabIndex = 24;
			this.forgotPswrdBtn.Text = "Forgot Password";
			this.forgotPswrdBtn.UseVisualStyleBackColor = true;
			this.forgotPswrdBtn.Click += new System.EventHandler(this.forgotPswrdBtn_Click);
			// 
			// proceedBtn
			// 
			this.proceedBtn.Location = new System.Drawing.Point(95, 237);
			this.proceedBtn.Name = "proceedBtn";
			this.proceedBtn.Size = new System.Drawing.Size(75, 23);
			this.proceedBtn.TabIndex = 25;
			this.proceedBtn.Text = "Proceed";
			this.proceedBtn.UseVisualStyleBackColor = true;
			this.proceedBtn.Click += new System.EventHandler(this.proceedBtn_Click);
			// 
			// XpayLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 341);
			this.Controls.Add(this.proceedBtn);
			this.Controls.Add(this.forgotPswrdBtn);
			this.Controls.Add(this.registerBtn);
			this.Controls.Add(this.passwordTb);
			this.Controls.Add(this.passwordLb);
			this.Controls.Add(this.emailTb);
			this.Controls.Add(this.emailLb);
			this.Controls.Add(this.regstrationLb);
			this.Controls.Add(this.xpayLb);
			this.Name = "XpayLogin";
			this.Text = "XpayLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label xpayLb;
		private System.Windows.Forms.Label regstrationLb;
		private System.Windows.Forms.TextBox passwordTb;
		private System.Windows.Forms.Label passwordLb;
		private System.Windows.Forms.TextBox emailTb;
		private System.Windows.Forms.Label emailLb;
		private System.Windows.Forms.Button registerBtn;
		private System.Windows.Forms.Button forgotPswrdBtn;
		private System.Windows.Forms.Button proceedBtn;
	}
}
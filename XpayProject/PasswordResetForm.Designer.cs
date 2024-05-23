namespace XpayProject
{
	partial class PasswordResetForm
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
			this.passwordRstLb = new System.Windows.Forms.Label();
			this.xpayLb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.securityAnswerTb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.emailTb = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.newPaswrdTb = new System.Windows.Forms.TextBox();
			this.submitBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.selectSecurityQsnsLb = new System.Windows.Forms.ListBox();
			this.proceedbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// passwordRstLb
			// 
			this.passwordRstLb.AutoSize = true;
			this.passwordRstLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordRstLb.Location = new System.Drawing.Point(129, 91);
			this.passwordRstLb.Name = "passwordRstLb";
			this.passwordRstLb.Size = new System.Drawing.Size(220, 24);
			this.passwordRstLb.TabIndex = 10;
			this.passwordRstLb.Text = "Password Reset  Form";
			// 
			// xpayLb
			// 
			this.xpayLb.AutoSize = true;
			this.xpayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xpayLb.Location = new System.Drawing.Point(108, 40);
			this.xpayLb.Name = "xpayLb";
			this.xpayLb.Size = new System.Drawing.Size(263, 39);
			this.xpayLb.TabIndex = 11;
			this.xpayLb.Text = "Xpay Life Bank";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(175, 224);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Select Qusetion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(166, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Type The Answer";
			// 
			// securityAnswerTb
			// 
			this.securityAnswerTb.Location = new System.Drawing.Point(149, 316);
			this.securityAnswerTb.Name = "securityAnswerTb";
			this.securityAnswerTb.Size = new System.Drawing.Size(182, 20);
			this.securityAnswerTb.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(166, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Enter Your Email-ID";
			// 
			// emailTb
			// 
			this.emailTb.Location = new System.Drawing.Point(149, 152);
			this.emailTb.Name = "emailTb";
			this.emailTb.Size = new System.Drawing.Size(182, 20);
			this.emailTb.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(166, 359);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Enter New PassWord";
			// 
			// newPaswrdTb
			// 
			this.newPaswrdTb.Location = new System.Drawing.Point(149, 399);
			this.newPaswrdTb.Name = "newPaswrdTb";
			this.newPaswrdTb.Size = new System.Drawing.Size(182, 20);
			this.newPaswrdTb.TabIndex = 3;
			// 
			// submitBtn
			// 
			this.submitBtn.Location = new System.Drawing.Point(149, 420);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(75, 23);
			this.submitBtn.TabIndex = 4;
			this.submitBtn.Text = "Submit";
			this.submitBtn.UseVisualStyleBackColor = true;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(213, 449);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(75, 23);
			this.backBtn.TabIndex = 5;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// selectSecurityQsnsLb
			// 
			this.selectSecurityQsnsLb.FormattingEnabled = true;
			this.selectSecurityQsnsLb.Location = new System.Drawing.Point(149, 255);
			this.selectSecurityQsnsLb.Name = "selectSecurityQsnsLb";
			this.selectSecurityQsnsLb.Size = new System.Drawing.Size(182, 17);
			this.selectSecurityQsnsLb.TabIndex = 1;
			// 
			// proceedbtn
			// 
			this.proceedbtn.Location = new System.Drawing.Point(198, 187);
			this.proceedbtn.Name = "proceedbtn";
			this.proceedbtn.Size = new System.Drawing.Size(75, 23);
			this.proceedbtn.TabIndex = 12;
			this.proceedbtn.Text = "Proceed";
			this.proceedbtn.UseVisualStyleBackColor = true;
			this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
			// 
			// PasswordResetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 479);
			this.Controls.Add(this.proceedbtn);
			this.Controls.Add(this.selectSecurityQsnsLb);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.newPaswrdTb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.emailTb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.securityAnswerTb);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordRstLb);
			this.Controls.Add(this.xpayLb);
			this.Name = "PasswordResetForm";
			this.Text = "PasswordResetForm";
			this.Load += new System.EventHandler(this.PasswordResetForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordRstLb;
		private System.Windows.Forms.Label xpayLb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox securityAnswerTb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox emailTb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox newPaswrdTb;
		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.ListBox selectSecurityQsnsLb;
		private System.Windows.Forms.Button proceedbtn;
	}
}
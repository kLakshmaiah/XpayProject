namespace XpayProject
{
	partial class UpdateTicketStatus
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
			this.updateLb = new System.Windows.Forms.Label();
			this.assignedLb = new System.Windows.Forms.Label();
			this.updateStatusCb = new System.Windows.Forms.ComboBox();
			this.assignedCb = new System.Windows.Forms.ComboBox();
			this.submitBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.descriptionTb = new System.Windows.Forms.TextBox();
			this.decriptionLb = new System.Windows.Forms.Label();
			this.problemTb = new System.Windows.Forms.TextBox();
			this.problemLb = new System.Windows.Forms.Label();
			this.mobileTb = new System.Windows.Forms.TextBox();
			this.mobileLb = new System.Windows.Forms.Label();
			this.emailTb = new System.Windows.Forms.TextBox();
			this.emailLb = new System.Windows.Forms.Label();
			this.nameTb = new System.Windows.Forms.TextBox();
			this.firstNameLb = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ticketIdCb = new System.Windows.Forms.ComboBox();
			this.ticketIdLb = new System.Windows.Forms.Label();
			this.remarksTb = new System.Windows.Forms.TextBox();
			this.remarksLb = new System.Windows.Forms.Label();
			this.assignedUserNameLb = new System.Windows.Forms.Label();
			this.currentStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateLb
			// 
			this.updateLb.AutoSize = true;
			this.updateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateLb.Location = new System.Drawing.Point(84, 287);
			this.updateLb.Name = "updateLb";
			this.updateLb.Size = new System.Drawing.Size(92, 13);
			this.updateLb.TabIndex = 1;
			this.updateLb.Text = "Update Status:";
			// 
			// assignedLb
			// 
			this.assignedLb.AutoSize = true;
			this.assignedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignedLb.Location = new System.Drawing.Point(93, 325);
			this.assignedLb.Name = "assignedLb";
			this.assignedLb.Size = new System.Drawing.Size(81, 13);
			this.assignedLb.TabIndex = 2;
			this.assignedLb.Text = "Assigned To:";
			// 
			// updateStatusCb
			// 
			this.updateStatusCb.FormattingEnabled = true;
			this.updateStatusCb.Location = new System.Drawing.Point(176, 284);
			this.updateStatusCb.Name = "updateStatusCb";
			this.updateStatusCb.Size = new System.Drawing.Size(121, 21);
			this.updateStatusCb.TabIndex = 4;
			this.updateStatusCb.SelectedIndexChanged += new System.EventHandler(this.ticketIdCb_SelectedIndexChanged);
			// 
			// assignedCb
			// 
			this.assignedCb.FormattingEnabled = true;
			this.assignedCb.Location = new System.Drawing.Point(176, 317);
			this.assignedCb.Name = "assignedCb";
			this.assignedCb.Size = new System.Drawing.Size(121, 21);
			this.assignedCb.TabIndex = 5;
			// 
			// submitBtn
			// 
			this.submitBtn.Location = new System.Drawing.Point(127, 347);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(75, 23);
			this.submitBtn.TabIndex = 6;
			this.submitBtn.Text = "submit";
			this.submitBtn.UseVisualStyleBackColor = true;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(240, 347);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(75, 23);
			this.backBtn.TabIndex = 7;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// descriptionTb
			// 
			this.descriptionTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.descriptionTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.descriptionTb.Location = new System.Drawing.Point(176, 247);
			this.descriptionTb.Name = "descriptionTb";
			this.descriptionTb.ReadOnly = true;
			this.descriptionTb.Size = new System.Drawing.Size(162, 20);
			this.descriptionTb.TabIndex = 31;
			// 
			// decriptionLb
			// 
			this.decriptionLb.AutoSize = true;
			this.decriptionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decriptionLb.Location = new System.Drawing.Point(98, 249);
			this.decriptionLb.Name = "decriptionLb";
			this.decriptionLb.Size = new System.Drawing.Size(75, 13);
			this.decriptionLb.TabIndex = 30;
			this.decriptionLb.Text = "Description:";
			// 
			// problemTb
			// 
			this.problemTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.problemTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.problemTb.Location = new System.Drawing.Point(176, 214);
			this.problemTb.Name = "problemTb";
			this.problemTb.ReadOnly = true;
			this.problemTb.Size = new System.Drawing.Size(162, 20);
			this.problemTb.TabIndex = 29;
			// 
			// problemLb
			// 
			this.problemLb.AutoSize = true;
			this.problemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.problemLb.Location = new System.Drawing.Point(117, 216);
			this.problemLb.Name = "problemLb";
			this.problemLb.Size = new System.Drawing.Size(56, 13);
			this.problemLb.TabIndex = 28;
			this.problemLb.Text = "Problem:";
			// 
			// mobileTb
			// 
			this.mobileTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.mobileTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mobileTb.Location = new System.Drawing.Point(176, 181);
			this.mobileTb.Name = "mobileTb";
			this.mobileTb.ReadOnly = true;
			this.mobileTb.Size = new System.Drawing.Size(162, 20);
			this.mobileTb.TabIndex = 27;
			// 
			// mobileLb
			// 
			this.mobileLb.AutoSize = true;
			this.mobileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mobileLb.Location = new System.Drawing.Point(124, 183);
			this.mobileLb.Name = "mobileLb";
			this.mobileLb.Size = new System.Drawing.Size(48, 13);
			this.mobileLb.TabIndex = 26;
			this.mobileLb.Text = "Mobile:";
			// 
			// emailTb
			// 
			this.emailTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.emailTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.emailTb.Location = new System.Drawing.Point(176, 148);
			this.emailTb.Name = "emailTb";
			this.emailTb.ReadOnly = true;
			this.emailTb.Size = new System.Drawing.Size(162, 20);
			this.emailTb.TabIndex = 25;
			// 
			// emailLb
			// 
			this.emailLb.AutoSize = true;
			this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLb.Location = new System.Drawing.Point(120, 150);
			this.emailLb.Name = "emailLb";
			this.emailLb.Size = new System.Drawing.Size(52, 13);
			this.emailLb.TabIndex = 24;
			this.emailLb.Text = "EmailId:";
			// 
			// nameTb
			// 
			this.nameTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nameTb.Location = new System.Drawing.Point(175, 115);
			this.nameTb.Name = "nameTb";
			this.nameTb.ReadOnly = true;
			this.nameTb.Size = new System.Drawing.Size(162, 20);
			this.nameTb.TabIndex = 23;
			// 
			// firstNameLb
			// 
			this.firstNameLb.AutoSize = true;
			this.firstNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLb.Location = new System.Drawing.Point(124, 117);
			this.firstNameLb.Name = "firstNameLb";
			this.firstNameLb.Size = new System.Drawing.Size(43, 13);
			this.firstNameLb.TabIndex = 22;
			this.firstNameLb.Text = "Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(124, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(254, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "Xpay Ticket Status Update";
			// 
			// ticketIdCb
			// 
			this.ticketIdCb.FormattingEnabled = true;
			this.ticketIdCb.Location = new System.Drawing.Point(175, 79);
			this.ticketIdCb.Name = "ticketIdCb";
			this.ticketIdCb.Size = new System.Drawing.Size(121, 21);
			this.ticketIdCb.TabIndex = 34;
			this.ticketIdCb.SelectedIndexChanged += new System.EventHandler(this.ticketIdCb_SelectedIndexChanged);
			// 
			// ticketIdLb
			// 
			this.ticketIdLb.AutoSize = true;
			this.ticketIdLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticketIdLb.Location = new System.Drawing.Point(111, 82);
			this.ticketIdLb.Name = "ticketIdLb";
			this.ticketIdLb.Size = new System.Drawing.Size(64, 13);
			this.ticketIdLb.TabIndex = 33;
			this.ticketIdLb.Text = "Ticket ID:";
			// 
			// remarksTb
			// 
			this.remarksTb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.remarksTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.remarksTb.Location = new System.Drawing.Point(175, 317);
			this.remarksTb.Name = "remarksTb";
			this.remarksTb.Size = new System.Drawing.Size(162, 20);
			this.remarksTb.TabIndex = 35;
			// 
			// remarksLb
			// 
			this.remarksLb.AutoSize = true;
			this.remarksLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.remarksLb.Location = new System.Drawing.Point(53, 323);
			this.remarksLb.Name = "remarksLb";
			this.remarksLb.Size = new System.Drawing.Size(117, 13);
			this.remarksLb.TabIndex = 36;
			this.remarksLb.Text = "Resolved Remarks:";
			// 
			// assignedUserNameLb
			// 
			this.assignedUserNameLb.AutoSize = true;
			this.assignedUserNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignedUserNameLb.Location = new System.Drawing.Point(343, 292);
			this.assignedUserNameLb.Name = "assignedUserNameLb";
			this.assignedUserNameLb.Size = new System.Drawing.Size(98, 13);
			this.assignedUserNameLb.TabIndex = 39;
			this.assignedUserNameLb.Text = "Assigned Name:";
			// 
			// currentStatus
			// 
			this.currentStatus.AutoSize = true;
			this.currentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentStatus.Location = new System.Drawing.Point(472, 292);
			this.currentStatus.Name = "currentStatus";
			this.currentStatus.Size = new System.Drawing.Size(91, 13);
			this.currentStatus.TabIndex = 40;
			this.currentStatus.Text = "current Status:";
			// 
			// UpdateTicketStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 474);
			this.Controls.Add(this.currentStatus);
			this.Controls.Add(this.assignedUserNameLb);
			this.Controls.Add(this.remarksLb);
			this.Controls.Add(this.remarksTb);
			this.Controls.Add(this.ticketIdCb);
			this.Controls.Add(this.ticketIdLb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.descriptionTb);
			this.Controls.Add(this.decriptionLb);
			this.Controls.Add(this.problemTb);
			this.Controls.Add(this.problemLb);
			this.Controls.Add(this.mobileTb);
			this.Controls.Add(this.mobileLb);
			this.Controls.Add(this.emailTb);
			this.Controls.Add(this.emailLb);
			this.Controls.Add(this.nameTb);
			this.Controls.Add(this.firstNameLb);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.assignedCb);
			this.Controls.Add(this.updateStatusCb);
			this.Controls.Add(this.assignedLb);
			this.Controls.Add(this.updateLb);
			this.Name = "UpdateTicketStatus";
			this.Text = "UpdateTicketStatus";
			this.Load += new System.EventHandler(this.UpdateTicketStatus_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label updateLb;
		private System.Windows.Forms.Label assignedLb;
		private System.Windows.Forms.ComboBox updateStatusCb;
		private System.Windows.Forms.ComboBox assignedCb;
		private System.Windows.Forms.Button submitBtn;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.TextBox descriptionTb;
		private System.Windows.Forms.Label decriptionLb;
		private System.Windows.Forms.TextBox problemTb;
		private System.Windows.Forms.Label problemLb;
		private System.Windows.Forms.TextBox mobileTb;
		private System.Windows.Forms.Label mobileLb;
		private System.Windows.Forms.TextBox emailTb;
		private System.Windows.Forms.Label emailLb;
		private System.Windows.Forms.TextBox nameTb;
		private System.Windows.Forms.Label firstNameLb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ticketIdCb;
		private System.Windows.Forms.Label ticketIdLb;
		private System.Windows.Forms.TextBox remarksTb;
		private System.Windows.Forms.Label remarksLb;
		private System.Windows.Forms.Label assignedUserNameLb;
		private System.Windows.Forms.Label currentStatus;
	}
}
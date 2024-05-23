namespace XpayProject
{
	partial class DashBoardPage
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
			this.loginSuceesLb = new System.Windows.Forms.Label();
			this.raiseTicketBtn = new System.Windows.Forms.Button();
			this.raisedTickets = new System.Windows.Forms.Button();
			this.ticketAnalysisBtn = new System.Windows.Forms.Button();
			this.updateTicketStatus = new System.Windows.Forms.Button();
			this.logoutBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xpayLb
			// 
			this.xpayLb.AutoSize = true;
			this.xpayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xpayLb.Location = new System.Drawing.Point(240, 26);
			this.xpayLb.Name = "xpayLb";
			this.xpayLb.Size = new System.Drawing.Size(273, 25);
			this.xpayLb.TabIndex = 3;
			this.xpayLb.Text = " Xpay Life Ticket System";
			// 
			// loginSuceesLb
			// 
			this.loginSuceesLb.AutoSize = true;
			this.loginSuceesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginSuceesLb.Location = new System.Drawing.Point(255, 63);
			this.loginSuceesLb.Name = "loginSuceesLb";
			this.loginSuceesLb.Size = new System.Drawing.Size(263, 20);
			this.loginSuceesLb.TabIndex = 4;
			this.loginSuceesLb.Text = "Login Successfull! Welcome To ";
			// 
			// raiseTicketBtn
			// 
			this.raiseTicketBtn.Location = new System.Drawing.Point(282, 97);
			this.raiseTicketBtn.Name = "raiseTicketBtn";
			this.raiseTicketBtn.Size = new System.Drawing.Size(106, 23);
			this.raiseTicketBtn.TabIndex = 5;
			this.raiseTicketBtn.Text = "RaiseTicket";
			this.raiseTicketBtn.UseVisualStyleBackColor = true;
			this.raiseTicketBtn.Click += new System.EventHandler(this.raiseTicketBtn_Click);
			// 
			// raisedTickets
			// 
			this.raisedTickets.Location = new System.Drawing.Point(282, 126);
			this.raisedTickets.Name = "raisedTickets";
			this.raisedTickets.Size = new System.Drawing.Size(106, 23);
			this.raisedTickets.TabIndex = 6;
			this.raisedTickets.Text = "RaisedTickets";
			this.raisedTickets.UseVisualStyleBackColor = true;
			this.raisedTickets.Click += new System.EventHandler(this.raisedTickets_Click);
			// 
			// ticketAnalysisBtn
			// 
			this.ticketAnalysisBtn.Location = new System.Drawing.Point(282, 155);
			this.ticketAnalysisBtn.Name = "ticketAnalysisBtn";
			this.ticketAnalysisBtn.Size = new System.Drawing.Size(106, 23);
			this.ticketAnalysisBtn.TabIndex = 7;
			this.ticketAnalysisBtn.Text = "TicketAnalysis";
			this.ticketAnalysisBtn.UseVisualStyleBackColor = true;
			this.ticketAnalysisBtn.Click += new System.EventHandler(this.ticketAnalysisBtn_Click);
			// 
			// updateTicketStatus
			// 
			this.updateTicketStatus.Location = new System.Drawing.Point(282, 184);
			this.updateTicketStatus.Name = "updateTicketStatus";
			this.updateTicketStatus.Size = new System.Drawing.Size(106, 23);
			this.updateTicketStatus.TabIndex = 8;
			this.updateTicketStatus.Text = "UpdateTicketStatus";
			this.updateTicketStatus.UseVisualStyleBackColor = true;
			this.updateTicketStatus.Click += new System.EventHandler(this.updateTicketStatus_Click);
			// 
			// logoutBtn
			// 
			this.logoutBtn.Location = new System.Drawing.Point(462, 206);
			this.logoutBtn.Name = "logoutBtn";
			this.logoutBtn.Size = new System.Drawing.Size(75, 23);
			this.logoutBtn.TabIndex = 9;
			this.logoutBtn.Text = "Logout";
			this.logoutBtn.UseVisualStyleBackColor = true;
			this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
			// 
			// DashBoardPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.logoutBtn);
			this.Controls.Add(this.updateTicketStatus);
			this.Controls.Add(this.ticketAnalysisBtn);
			this.Controls.Add(this.raisedTickets);
			this.Controls.Add(this.raiseTicketBtn);
			this.Controls.Add(this.loginSuceesLb);
			this.Controls.Add(this.xpayLb);
			this.Name = "DashBoardPage";
			this.Text = "DashBoardPage";
			this.Load += new System.EventHandler(this.DashBoardPage_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label xpayLb;
		private System.Windows.Forms.Label loginSuceesLb;
		private System.Windows.Forms.Button raiseTicketBtn;
		private System.Windows.Forms.Button raisedTickets;
		private System.Windows.Forms.Button ticketAnalysisBtn;
		private System.Windows.Forms.Button updateTicketStatus;
		private System.Windows.Forms.Button logoutBtn;
	}
}
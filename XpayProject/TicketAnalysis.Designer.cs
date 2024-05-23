namespace XpayProject
{
	partial class TicketAnalysis
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.intializeLb = new System.Windows.Forms.Label();
			this.xpayTicket = new System.Windows.Forms.Label();
			this.reOpenLb = new System.Windows.Forms.Label();
			this.closedLb = new System.Windows.Forms.Label();
			this.resolvedLb = new System.Windows.Forms.Label();
			this.assignedLb = new System.Windows.Forms.Label();
			this.unAssignedLb = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.backBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// intializeLb
			// 
			this.intializeLb.AutoSize = true;
			this.intializeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.intializeLb.Location = new System.Drawing.Point(81, 110);
			this.intializeLb.Name = "intializeLb";
			this.intializeLb.Size = new System.Drawing.Size(55, 13);
			this.intializeLb.TabIndex = 23;
			this.intializeLb.Text = "Intialize:";
			// 
			// xpayTicket
			// 
			this.xpayTicket.AutoSize = true;
			this.xpayTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xpayTicket.Location = new System.Drawing.Point(198, 44);
			this.xpayTicket.Name = "xpayTicket";
			this.xpayTicket.Size = new System.Drawing.Size(214, 24);
			this.xpayTicket.TabIndex = 33;
			this.xpayTicket.Text = "Xpay Ticket Analaysis";
			// 
			// reOpenLb
			// 
			this.reOpenLb.AutoSize = true;
			this.reOpenLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reOpenLb.Location = new System.Drawing.Point(81, 255);
			this.reOpenLb.Name = "reOpenLb";
			this.reOpenLb.Size = new System.Drawing.Size(61, 13);
			this.reOpenLb.TabIndex = 34;
			this.reOpenLb.Text = "Re-Open:";
			// 
			// closedLb
			// 
			this.closedLb.AutoSize = true;
			this.closedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closedLb.Location = new System.Drawing.Point(81, 226);
			this.closedLb.Name = "closedLb";
			this.closedLb.Size = new System.Drawing.Size(49, 13);
			this.closedLb.TabIndex = 35;
			this.closedLb.Text = "Closed:";
			// 
			// resolvedLb
			// 
			this.resolvedLb.AutoSize = true;
			this.resolvedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resolvedLb.Location = new System.Drawing.Point(81, 197);
			this.resolvedLb.Name = "resolvedLb";
			this.resolvedLb.Size = new System.Drawing.Size(64, 13);
			this.resolvedLb.TabIndex = 36;
			this.resolvedLb.Text = "Resolved:";
			// 
			// assignedLb
			// 
			this.assignedLb.AutoSize = true;
			this.assignedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.assignedLb.Location = new System.Drawing.Point(81, 168);
			this.assignedLb.Name = "assignedLb";
			this.assignedLb.Size = new System.Drawing.Size(62, 13);
			this.assignedLb.TabIndex = 37;
			this.assignedLb.Text = "Assigned:";
			// 
			// unAssignedLb
			// 
			this.unAssignedLb.AutoSize = true;
			this.unAssignedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unAssignedLb.Location = new System.Drawing.Point(81, 139);
			this.unAssignedLb.Name = "unAssignedLb";
			this.unAssignedLb.Size = new System.Drawing.Size(77, 13);
			this.unAssignedLb.TabIndex = 38;
			this.unAssignedLb.Text = "Unassigned:";
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			chartArea2.AxisX.Title = "Tickets";
			chartArea2.AxisY.Title = "Number Of Ticket";
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(81, 300);
			this.chart1.Name = "chart1";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "countTicket";
			series2.ShadowColor = System.Drawing.Color.Blue;
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(650, 300);
			this.chart1.TabIndex = 39;
			this.chart1.Text = "Count_Ticket";
			title2.Name = "chartTittle";
			title2.Text = "TickeTAnalysis";
			this.chart1.Titles.Add(title2);
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(726, 568);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(75, 23);
			this.backBtn.TabIndex = 40;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// TicketAnalysis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(845, 633);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.unAssignedLb);
			this.Controls.Add(this.assignedLb);
			this.Controls.Add(this.resolvedLb);
			this.Controls.Add(this.closedLb);
			this.Controls.Add(this.reOpenLb);
			this.Controls.Add(this.xpayTicket);
			this.Controls.Add(this.intializeLb);
			this.Name = "TicketAnalysis";
			this.Text = "TicketAnalysis";
			this.Load += new System.EventHandler(this.TicketAnalysis_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label intializeLb;
		private System.Windows.Forms.Label xpayTicket;
		private System.Windows.Forms.Label reOpenLb;
		private System.Windows.Forms.Label closedLb;
		private System.Windows.Forms.Label resolvedLb;
		private System.Windows.Forms.Label assignedLb;
		private System.Windows.Forms.Label unAssignedLb;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button backBtn;
	}
}
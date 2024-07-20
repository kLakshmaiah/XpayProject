namespace XpayProject
{
	partial class TicketDetailsForm
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
            this.statusDetails = new System.Windows.Forms.ComboBox();
            this.selectLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDetails
            // 
            this.statusDetails.FormattingEnabled = true;
            this.statusDetails.Location = new System.Drawing.Point(432, 7);
            this.statusDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusDetails.Name = "statusDetails";
            this.statusDetails.Size = new System.Drawing.Size(160, 24);
            this.statusDetails.TabIndex = 1;
            this.statusDetails.SelectedIndexChanged += new System.EventHandler(this.statusDetails_SelectedIndexChanged);
            // 
            // selectLb
            // 
            this.selectLb.AutoSize = true;
            this.selectLb.Location = new System.Drawing.Point(356, 18);
            this.selectLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectLb.Name = "selectLb";
            this.selectLb.Size = new System.Drawing.Size(45, 16);
            this.selectLb.TabIndex = 2;
            this.selectLb.Text = "Select";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1647, 513);
            this.dataGridView1.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(629, 6);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 28);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TicketDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 554);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectLb);
            this.Controls.Add(this.statusDetails);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketDetailsForm";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox statusDetails;
		private System.Windows.Forms.Label selectLb;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button backBtn;
	}
}
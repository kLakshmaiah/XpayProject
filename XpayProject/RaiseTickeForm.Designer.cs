namespace XpayProject
{
	partial class RaiseTickeForm
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
			this.backBtn = new System.Windows.Forms.Button();
			this.raiseTckt = new System.Windows.Forms.Button();
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
			this.SuspendLayout();
			// 
			// xpayLb
			// 
			this.xpayLb.AutoSize = true;
			this.xpayLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.xpayLb.Location = new System.Drawing.Point(142, 38);
			this.xpayLb.Name = "xpayLb";
			this.xpayLb.Size = new System.Drawing.Size(143, 25);
			this.xpayLb.TabIndex = 2;
			this.xpayLb.Text = "Raise Ticket";
			// 
			// backBtn
			// 
			this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.backBtn.ForeColor = System.Drawing.SystemColors.Control;
			this.backBtn.Location = new System.Drawing.Point(207, 242);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(121, 23);
			this.backBtn.TabIndex = 3;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// raiseTckt
			// 
			this.raiseTckt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.raiseTckt.ForeColor = System.Drawing.SystemColors.Control;
			this.raiseTckt.Location = new System.Drawing.Point(67, 242);
			this.raiseTckt.Name = "raiseTckt";
			this.raiseTckt.Size = new System.Drawing.Size(121, 23);
			this.raiseTckt.TabIndex = 4;
			this.raiseTckt.Text = "Raise Ticket";
			this.raiseTckt.UseVisualStyleBackColor = false;
			this.raiseTckt.Click += new System.EventHandler(this.raiseTckt_Click);
			// 
			// descriptionTb
			// 
			this.descriptionTb.BackColor = System.Drawing.Color.Yellow;
			this.descriptionTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descriptionTb.Location = new System.Drawing.Point(130, 195);
			this.descriptionTb.Name = "descriptionTb";
			this.descriptionTb.Size = new System.Drawing.Size(162, 13);
			this.descriptionTb.TabIndex = 21;
			// 
			// decriptionLb
			// 
			this.decriptionLb.AutoSize = true;
			this.decriptionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decriptionLb.Location = new System.Drawing.Point(64, 195);
			this.decriptionLb.Name = "decriptionLb";
			this.decriptionLb.Size = new System.Drawing.Size(63, 13);
			this.decriptionLb.TabIndex = 20;
			this.decriptionLb.Text = "Description:";
			// 
			// problemTb
			// 
			this.problemTb.BackColor = System.Drawing.Color.Yellow;
			this.problemTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.problemTb.Location = new System.Drawing.Point(130, 169);
			this.problemTb.Name = "problemTb";
			this.problemTb.Size = new System.Drawing.Size(162, 13);
			this.problemTb.TabIndex = 19;
			// 
			// problemLb
			// 
			this.problemLb.AutoSize = true;
			this.problemLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.problemLb.Location = new System.Drawing.Point(79, 169);
			this.problemLb.Name = "problemLb";
			this.problemLb.Size = new System.Drawing.Size(48, 13);
			this.problemLb.TabIndex = 18;
			this.problemLb.Text = "Problem:";
			// 
			// mobileTb
			// 
			this.mobileTb.BackColor = System.Drawing.Color.Yellow;
			this.mobileTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mobileTb.Location = new System.Drawing.Point(130, 143);
			this.mobileTb.Name = "mobileTb";
			this.mobileTb.Size = new System.Drawing.Size(162, 13);
			this.mobileTb.TabIndex = 17;
			// 
			// mobileLb
			// 
			this.mobileLb.AutoSize = true;
			this.mobileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mobileLb.Location = new System.Drawing.Point(83, 143);
			this.mobileLb.Name = "mobileLb";
			this.mobileLb.Size = new System.Drawing.Size(41, 13);
			this.mobileLb.TabIndex = 16;
			this.mobileLb.Text = "Mobile:";
			// 
			// emailTb
			// 
			this.emailTb.BackColor = System.Drawing.Color.Yellow;
			this.emailTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailTb.Location = new System.Drawing.Point(130, 117);
			this.emailTb.Name = "emailTb";
			this.emailTb.Size = new System.Drawing.Size(162, 13);
			this.emailTb.TabIndex = 15;
			// 
			// emailLb
			// 
			this.emailLb.AutoSize = true;
			this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLb.Location = new System.Drawing.Point(83, 117);
			this.emailLb.Name = "emailLb";
			this.emailLb.Size = new System.Drawing.Size(44, 13);
			this.emailLb.TabIndex = 14;
			this.emailLb.Text = "EmailId:";
			// 
			// nameTb
			// 
			this.nameTb.BackColor = System.Drawing.Color.Yellow;
			this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameTb.Location = new System.Drawing.Point(129, 90);
			this.nameTb.Name = "nameTb";
			this.nameTb.Size = new System.Drawing.Size(162, 13);
			this.nameTb.TabIndex = 13;
			// 
			// firstNameLb
			// 
			this.firstNameLb.AutoSize = true;
			this.firstNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLb.Location = new System.Drawing.Point(89, 90);
			this.firstNameLb.Name = "firstNameLb";
			this.firstNameLb.Size = new System.Drawing.Size(38, 13);
			this.firstNameLb.TabIndex = 12;
			this.firstNameLb.Text = "Name:";
			// 
			// RaiseTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 361);
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
			this.Controls.Add(this.raiseTckt);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.xpayLb);
			this.Name = "RaiseTicket";
			this.Text = "RaiseTicket";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label xpayLb;
		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Button raiseTckt;
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
	}
}
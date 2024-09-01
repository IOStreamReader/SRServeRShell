namespace SRServerRShell
{
	partial class Comment
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
			this.btnConfirm = new System.Windows.Forms.Button();
			this.txtBxComment = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(377, 12);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "确定";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// txtBxComment
			// 
			this.txtBxComment.Location = new System.Drawing.Point(12, 14);
			this.txtBxComment.Name = "txtBxComment";
			this.txtBxComment.Size = new System.Drawing.Size(359, 21);
			this.txtBxComment.TabIndex = 1;
			// 
			// Comment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 48);
			this.Controls.Add(this.txtBxComment);
			this.Controls.Add(this.btnConfirm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Comment";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "设置备注...";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comment_Closing);
			this.Load += new System.EventHandler(this.Comment_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.TextBox txtBxComment;
	}
}
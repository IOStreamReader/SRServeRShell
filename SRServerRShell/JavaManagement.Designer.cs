namespace SRServerRShell
{
	partial class JavaManagement
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavaManagement));
			this.lwJava = new System.Windows.Forms.ListView();
			this.headerPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.headerComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddJava = new System.Windows.Forms.Button();
			this.btnDeleteJava = new System.Windows.Forms.Button();
			this.btnSaveClose = new System.Windows.Forms.Button();
			this.ofJRE = new System.Windows.Forms.OpenFileDialog();
			this.btnComment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lwJava
			// 
			this.lwJava.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerPath,
            this.headerComment});
			this.lwJava.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			listViewGroup1.Header = "ListViewGroup";
			listViewGroup1.Name = "lwName";
			listViewGroup2.Header = "ListViewGroup";
			listViewGroup2.Name = "lwComment";
			this.lwJava.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			this.lwJava.HideSelection = false;
			this.lwJava.Location = new System.Drawing.Point(12, 12);
			this.lwJava.Name = "lwJava";
			this.lwJava.Size = new System.Drawing.Size(440, 388);
			this.lwJava.TabIndex = 0;
			this.lwJava.UseCompatibleStateImageBehavior = false;
			this.lwJava.View = System.Windows.Forms.View.List;
			// 
			// headerPath
			// 
			this.headerPath.Width = 330;
			// 
			// headerComment
			// 
			this.headerComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.headerComment.Width = 110;
			// 
			// btnAddJava
			// 
			this.btnAddJava.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnAddJava.Location = new System.Drawing.Point(12, 406);
			this.btnAddJava.Name = "btnAddJava";
			this.btnAddJava.Size = new System.Drawing.Size(75, 23);
			this.btnAddJava.TabIndex = 1;
			this.btnAddJava.Text = "添加";
			this.btnAddJava.UseVisualStyleBackColor = true;
			this.btnAddJava.Click += new System.EventHandler(this.btnAddJava_Click);
			// 
			// btnDeleteJava
			// 
			this.btnDeleteJava.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnDeleteJava.Location = new System.Drawing.Point(93, 406);
			this.btnDeleteJava.Name = "btnDeleteJava";
			this.btnDeleteJava.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteJava.TabIndex = 2;
			this.btnDeleteJava.Text = "删除";
			this.btnDeleteJava.UseVisualStyleBackColor = true;
			this.btnDeleteJava.Click += new System.EventHandler(this.btnDeleteJava_Click);
			// 
			// btnSaveClose
			// 
			this.btnSaveClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSaveClose.Location = new System.Drawing.Point(355, 406);
			this.btnSaveClose.Name = "btnSaveClose";
			this.btnSaveClose.Size = new System.Drawing.Size(97, 23);
			this.btnSaveClose.TabIndex = 3;
			this.btnSaveClose.Text = "保存并关闭";
			this.btnSaveClose.UseVisualStyleBackColor = true;
			this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
			// 
			// ofJRE
			// 
			this.ofJRE.Filter = "java|java.exe";
			this.ofJRE.InitialDirectory = "C:\\Program Files\\Java";
			this.ofJRE.Title = "选择java.exe";
			this.ofJRE.FileOk += new System.ComponentModel.CancelEventHandler(this.ofJRE_FileOk);
			// 
			// btnComment
			// 
			this.btnComment.Enabled = false;
			this.btnComment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnComment.Location = new System.Drawing.Point(174, 406);
			this.btnComment.Name = "btnComment";
			this.btnComment.Size = new System.Drawing.Size(101, 23);
			this.btnComment.TabIndex = 4;
			this.btnComment.Text = "设置备注[WIP]";
			this.btnComment.UseVisualStyleBackColor = true;
			this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
			// 
			// JavaManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 441);
			this.Controls.Add(this.btnComment);
			this.Controls.Add(this.btnSaveClose);
			this.Controls.Add(this.btnDeleteJava);
			this.Controls.Add(this.btnAddJava);
			this.Controls.Add(this.lwJava);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "JavaManagement";
			this.Text = "管理现存的Java运行环境";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagementClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lwJava;
		private System.Windows.Forms.ColumnHeader headerPath;
		private System.Windows.Forms.ColumnHeader headerComment;
		private System.Windows.Forms.Button btnAddJava;
		private System.Windows.Forms.Button btnDeleteJava;
		private System.Windows.Forms.Button btnSaveClose;
		private System.Windows.Forms.OpenFileDialog ofJRE;
		private System.Windows.Forms.Button btnComment;
	}
}
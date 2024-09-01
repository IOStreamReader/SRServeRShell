namespace SRServerRShell
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelJavaPrompt = new System.Windows.Forms.Label();
			this.comboboxJavaPath = new System.Windows.Forms.ComboBox();
			this.btnSetJava = new System.Windows.Forms.Button();
			this.labelServerCorePrompt = new System.Windows.Forms.Label();
			this.txtbxServerCore = new System.Windows.Forms.TextBox();
			this.btnSelectCore = new System.Windows.Forms.Button();
			this.ofServerCore = new System.Windows.Forms.OpenFileDialog();
			this.btnLaunch = new System.Windows.Forms.Button();
			this.txtBxArgs = new System.Windows.Forms.TextBox();
			this.labelJavaArgs = new System.Windows.Forms.Label();
			this.btnAdvancedSettings = new System.Windows.Forms.Button();
			this.rtxtbxConsoleOutput = new System.Windows.Forms.RichTextBox();
			this.txtbxMsg = new System.Windows.Forms.TextBox();
			this.btnSendMsg = new System.Windows.Forms.Button();
			this.btnSendBatch = new System.Windows.Forms.Button();
			this.ofBatchScript = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// labelJavaPrompt
			// 
			this.labelJavaPrompt.AutoSize = true;
			this.labelJavaPrompt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelJavaPrompt.Location = new System.Drawing.Point(12, 11);
			this.labelJavaPrompt.Name = "labelJavaPrompt";
			this.labelJavaPrompt.Size = new System.Drawing.Size(122, 21);
			this.labelJavaPrompt.TabIndex = 0;
			this.labelJavaPrompt.Text = "Java运行时路径";
			// 
			// comboboxJavaPath
			// 
			this.comboboxJavaPath.FormattingEnabled = true;
			this.comboboxJavaPath.Location = new System.Drawing.Point(140, 12);
			this.comboboxJavaPath.Name = "comboboxJavaPath";
			this.comboboxJavaPath.Size = new System.Drawing.Size(471, 20);
			this.comboboxJavaPath.TabIndex = 1;
			// 
			// btnSetJava
			// 
			this.btnSetJava.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSetJava.Location = new System.Drawing.Point(617, 9);
			this.btnSetJava.Name = "btnSetJava";
			this.btnSetJava.Size = new System.Drawing.Size(75, 23);
			this.btnSetJava.TabIndex = 2;
			this.btnSetJava.Text = "管理...";
			this.btnSetJava.UseVisualStyleBackColor = true;
			this.btnSetJava.Click += new System.EventHandler(this.btnSetJava_Click);
			// 
			// labelServerCorePrompt
			// 
			this.labelServerCorePrompt.AutoSize = true;
			this.labelServerCorePrompt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelServerCorePrompt.Location = new System.Drawing.Point(12, 38);
			this.labelServerCorePrompt.Name = "labelServerCorePrompt";
			this.labelServerCorePrompt.Size = new System.Drawing.Size(196, 21);
			this.labelServerCorePrompt.TabIndex = 3;
			this.labelServerCorePrompt.Text = "Minecraft服务端核心文件";
			// 
			// txtbxServerCore
			// 
			this.txtbxServerCore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtbxServerCore.Location = new System.Drawing.Point(214, 38);
			this.txtbxServerCore.Name = "txtbxServerCore";
			this.txtbxServerCore.Size = new System.Drawing.Size(397, 23);
			this.txtbxServerCore.TabIndex = 4;
			// 
			// btnSelectCore
			// 
			this.btnSelectCore.Location = new System.Drawing.Point(617, 38);
			this.btnSelectCore.Name = "btnSelectCore";
			this.btnSelectCore.Size = new System.Drawing.Size(75, 23);
			this.btnSelectCore.TabIndex = 5;
			this.btnSelectCore.Text = "选择";
			this.btnSelectCore.UseVisualStyleBackColor = true;
			this.btnSelectCore.Click += new System.EventHandler(this.btnSelectCore_Click);
			// 
			// ofServerCore
			// 
			this.ofServerCore.Filter = "Jar包|*.jar";
			this.ofServerCore.Title = "选择服务端核心";
			this.ofServerCore.FileOk += new System.ComponentModel.CancelEventHandler(this.ofServerCore_FileOk);
			// 
			// btnLaunch
			// 
			this.btnLaunch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnLaunch.Location = new System.Drawing.Point(578, 67);
			this.btnLaunch.Name = "btnLaunch";
			this.btnLaunch.Size = new System.Drawing.Size(114, 23);
			this.btnLaunch.TabIndex = 6;
			this.btnLaunch.Text = "瑞典原神，启动！";
			this.btnLaunch.UseVisualStyleBackColor = true;
			this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
			// 
			// txtBxArgs
			// 
			this.txtBxArgs.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtBxArgs.Location = new System.Drawing.Point(93, 67);
			this.txtBxArgs.Name = "txtBxArgs";
			this.txtBxArgs.Size = new System.Drawing.Size(374, 23);
			this.txtBxArgs.TabIndex = 7;
			this.txtBxArgs.TextChanged += new System.EventHandler(this.txtBxArgs_TextChanged);
			// 
			// labelJavaArgs
			// 
			this.labelJavaArgs.AutoSize = true;
			this.labelJavaArgs.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelJavaArgs.Location = new System.Drawing.Point(12, 67);
			this.labelJavaArgs.Name = "labelJavaArgs";
			this.labelJavaArgs.Size = new System.Drawing.Size(75, 21);
			this.labelJavaArgs.TabIndex = 8;
			this.labelJavaArgs.Text = "JVM参数";
			// 
			// btnAdvancedSettings
			// 
			this.btnAdvancedSettings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnAdvancedSettings.Location = new System.Drawing.Point(473, 68);
			this.btnAdvancedSettings.Name = "btnAdvancedSettings";
			this.btnAdvancedSettings.Size = new System.Drawing.Size(99, 23);
			this.btnAdvancedSettings.TabIndex = 9;
			this.btnAdvancedSettings.Text = "高级设置[WIP]";
			this.btnAdvancedSettings.UseVisualStyleBackColor = true;
			// 
			// rtxtbxConsoleOutput
			// 
			this.rtxtbxConsoleOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rtxtbxConsoleOutput.Location = new System.Drawing.Point(16, 96);
			this.rtxtbxConsoleOutput.Name = "rtxtbxConsoleOutput";
			this.rtxtbxConsoleOutput.ReadOnly = true;
			this.rtxtbxConsoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtxtbxConsoleOutput.Size = new System.Drawing.Size(676, 465);
			this.rtxtbxConsoleOutput.TabIndex = 10;
			this.rtxtbxConsoleOutput.Text = "";
			// 
			// txtbxMsg
			// 
			this.txtbxMsg.Location = new System.Drawing.Point(16, 568);
			this.txtbxMsg.Name = "txtbxMsg";
			this.txtbxMsg.Size = new System.Drawing.Size(544, 21);
			this.txtbxMsg.TabIndex = 11;
			// 
			// btnSendMsg
			// 
			this.btnSendMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSendMsg.Location = new System.Drawing.Point(566, 567);
			this.btnSendMsg.Name = "btnSendMsg";
			this.btnSendMsg.Size = new System.Drawing.Size(45, 23);
			this.btnSendMsg.TabIndex = 12;
			this.btnSendMsg.Text = "发送";
			this.btnSendMsg.UseVisualStyleBackColor = true;
			this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
			// 
			// btnSendBatch
			// 
			this.btnSendBatch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSendBatch.Location = new System.Drawing.Point(617, 567);
			this.btnSendBatch.Name = "btnSendBatch";
			this.btnSendBatch.Size = new System.Drawing.Size(75, 23);
			this.btnSendBatch.TabIndex = 13;
			this.btnSendBatch.Text = "批量发送";
			this.btnSendBatch.UseVisualStyleBackColor = true;
			this.btnSendBatch.Click += new System.EventHandler(this.btnSendBatch_Click);
			// 
			// ofBatchScript
			// 
			this.ofBatchScript.Filter = "txt file|*.txt";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 601);
			this.Controls.Add(this.btnSendBatch);
			this.Controls.Add(this.btnSendMsg);
			this.Controls.Add(this.txtbxMsg);
			this.Controls.Add(this.rtxtbxConsoleOutput);
			this.Controls.Add(this.btnAdvancedSettings);
			this.Controls.Add(this.labelJavaArgs);
			this.Controls.Add(this.txtBxArgs);
			this.Controls.Add(this.btnLaunch);
			this.Controls.Add(this.btnSelectCore);
			this.Controls.Add(this.txtbxServerCore);
			this.Controls.Add(this.labelServerCorePrompt);
			this.Controls.Add(this.btnSetJava);
			this.Controls.Add(this.comboboxJavaPath);
			this.Controls.Add(this.labelJavaPrompt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "SR\'s ServeR Shell v0.1a";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelJavaPrompt;
		private System.Windows.Forms.ComboBox comboboxJavaPath;
		private System.Windows.Forms.Button btnSetJava;
		private System.Windows.Forms.Label labelServerCorePrompt;
		private System.Windows.Forms.TextBox txtbxServerCore;
		private System.Windows.Forms.Button btnSelectCore;
		private System.Windows.Forms.OpenFileDialog ofServerCore;
		private System.Windows.Forms.Button btnLaunch;
		private System.Windows.Forms.TextBox txtBxArgs;
		private System.Windows.Forms.Label labelJavaArgs;
		private System.Windows.Forms.Button btnAdvancedSettings;
		private System.Windows.Forms.RichTextBox rtxtbxConsoleOutput;
		private System.Windows.Forms.TextBox txtbxMsg;
		private System.Windows.Forms.Button btnSendMsg;
		private System.Windows.Forms.Button btnSendBatch;
		private System.Windows.Forms.OpenFileDialog ofBatchScript;
	}
}


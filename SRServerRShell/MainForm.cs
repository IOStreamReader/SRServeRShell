using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRServerRShell
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Variants.LoadConfig();
			foreach (string java in Variants.JavaList)
			{
				comboboxJavaPath.Items.Add(java);
			}
			txtBxArgs.Text = Variants.Args;
			txtbxServerCore.Text = Variants.ServerCorePath;
		}

		private void btnSelectCore_Click(object sender, EventArgs e)
		{
			ofServerCore.ShowDialog();
		}

		private void ofServerCore_FileOk(object sender, CancelEventArgs e)
		{
			Variants.ServerCorePath = ofServerCore.FileName;
			txtbxServerCore.Text = Variants.ServerCorePath;
			Variants.SaveConfig();
		}

		private void btnSetJava_Click(object sender, EventArgs e)
		{
			JavaManagement jmDialog = new JavaManagement();
			jmDialog.ShowDialog();
			Variants.JavaList = JavaManagement.JavaList;
			comboboxJavaPath.Items.Clear();
			comboboxJavaPath.Items.AddRange(Variants.JavaList.ToArray());
		}

		private void txtBxArgs_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnLaunch_Click(object sender, EventArgs e)
		{
			if (!Variants.running)
			{
				Variants.Args = txtBxArgs.Text;
				Variants.JavaPath = comboboxJavaPath.SelectedItem.ToString();
				Variants.ServerCorePath = txtbxServerCore.Text;
				Variants.SaveConfig();
				txtBxArgs.Enabled = false;
				comboboxJavaPath.Enabled = false;
				txtbxServerCore.Enabled = false;
				ServerThread.InitServer();
				btnLaunch.Text = "强制停止";
				if(Program.consolesync.ThreadState == ThreadState.Unstarted)
					Program.consolesync.Start();
				else
					Program.consolesync.Resume();
			}
			else
			{
				try
				{
					ServerThread.serverProcess.StandardInput.WriteLine("stop");
					ServerThread.serverProcess.WaitForExit();
				}
				catch
				{
					ServerThread.serverProcess.Kill();
				}
				Program.consolesync.Join();
				Variants.running = false;
				Release();
			}
		}
		public void Release()
		{
			btnLaunch.Text = "重新启动";
			txtBxArgs.Enabled = true;
			comboboxJavaPath.Enabled = true;
			txtbxServerCore.Enabled = true;
		}

		private void btnSendMsg_Click(object sender, EventArgs e)
		{
			ServerThread.serverProcess.StandardInput.WriteLine(txtbxMsg.Text);
		}
		public void SyncMsg()
		{
			while (true)
			{
				if (ServerThread.OutStream.Count > 0)
				{
					AppendMsg();
				}
				else
					Thread.Sleep(50);
			}
		}
		public void AppendMsg()
		{
			if (rtxtbxConsoleOutput.InvokeRequired)
			{
				rtxtbxConsoleOutput.Invoke(new Action(AppendMsg));
			}
			else
			{
				rtxtbxConsoleOutput.AppendText(ServerThread.OutStream.Dequeue() + "\n");
			}
		}

		private void btnSendBatch_Click(object sender, EventArgs e)
		{
			ofBatchScript.ShowDialog();
			string path = ofBatchScript.FileName;
			string[] lines = System.IO.File.ReadAllLines(path);
			foreach (string line in lines)
			{
				ServerThread.serverProcess.StandardInput.WriteLine(line);
				Thread.Sleep(100);
			}
		}
	}
}

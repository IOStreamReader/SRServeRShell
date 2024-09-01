using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRServerRShell
{
	public static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm mf = new MainForm();
			consolesync = new Thread(mf.SyncMsg);
			Application.Run(mf);
			ServerThread.serverProcess.Kill();
		}
		public static Thread consolesync;
	}
}

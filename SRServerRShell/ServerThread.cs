using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace SRServerRShell
{
	public static class ServerThread
	{
		public static Queue<string> OutStream = new Queue<string>();
		public static Process serverProcess = new Process();
		public static event DataReceivedEventHandler OutputDataReceived;
		public static event DataReceivedEventHandler ErrorDataReceived;

		public static void InitServer()
		{
			serverProcess = new Process();
			serverProcess.StartInfo.FileName = Variants.JavaPath;
			serverProcess.StartInfo.Arguments = Variants.Args + " -jar " + Variants.ServerCorePath + " nogui";
			serverProcess.StartInfo.UseShellExecute = false;
			serverProcess.StartInfo.RedirectStandardInput = true;
			serverProcess.StartInfo.RedirectStandardOutput = true;
			serverProcess.StartInfo.RedirectStandardError = true;
			serverProcess.StartInfo.CreateNoWindow = true;
			serverProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
			serverProcess.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);
			serverProcess.Start();
			serverProcess.BeginOutputReadLine();
			serverProcess.BeginErrorReadLine();
			Variants.running = true;
		}
		public static void RestartServer()
		{
			serverProcess.Kill();
			InitServer();
			serverProcess.Start();
			serverProcess.BeginOutputReadLine();
			serverProcess.BeginErrorReadLine();
			Variants.running = true;
		}
		private static void OutputHandler(object sender, DataReceivedEventArgs e)
		{
			if (e.Data != null)
			{
				OutStream.Enqueue(e.Data);
			}
			if(OutputDataReceived != null)
				OutputDataReceived.Invoke(sender, e);
		}

		private static void ErrorHandler(object sender, DataReceivedEventArgs e)
		{
			if(ErrorDataReceived!= null)
				ErrorDataReceived.Invoke(sender, e);
		}
		
	}
}

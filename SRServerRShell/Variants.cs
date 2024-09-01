using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SRServerRShell
{
	internal static class Variants
	{
		static string configpath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData)+@"\srsrs";
		public static bool running = false;
		public static string ServerCorePath = "";
		public static string JavaPath = "";
		public static string Args = "";
		public static List<string> JavaList = new List<string>();
		public static void SaveConfig()
		{
			try
			{
				if (!Directory.Exists(configpath))
				{
					Directory.CreateDirectory(configpath);
				}

				File.WriteAllText("srsrs.cfg", ServerCorePath + "\n" + JavaPath + "\n" + Args);
				File.WriteAllText(configpath + @"\java.cfg", string.Join("\n", JavaList.ToArray()));
			}
			catch (Exception e)
			{
				MessageBox.Show("Error saving config: " + e.Message);
			}
		}
		public static void LoadConfig()
		{
			if (File.Exists("srsrs.cfg")&&File.Exists(configpath+@"\java.cfg"))
			{
				try
				{
					string[] cfg = File.ReadAllLines("srsrs.cfg");
					try
					{
						ServerCorePath = cfg[0];
						JavaPath = cfg[1];
						Args = cfg[2];
					}
					catch
					{
						// too lazy to solve :P
					}
					JavaList = new List<string>(File.ReadAllLines(configpath + @"\java.cfg"));
				}
				catch (Exception e)
				{
					MessageBox.Show("Error loading config: " + e.StackTrace);
				}
			}
		}
	}
}

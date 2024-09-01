using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRServerRShell
{
	public partial class JavaManagement : Form
	{
		public static List<string> JavaList = new List<string>();
		public JavaManagement()
		{
			InitializeComponent();
		}

		private void btnAddJava_Click(object sender, EventArgs e)
		{
			ofJRE.ShowDialog();
		}

		private void ofJRE_FileOk(object sender, CancelEventArgs e)
		{
			lwJava.Items.Add(ofJRE.FileName);
		}

		private void btnComment_Click(object sender, EventArgs e)
		{
			string comment = "";
			Comment commentDialog = new Comment();
			commentDialog.ShowDialog();
			comment = Comment.CommentText;
			lwJava.SelectedItems[0].SubItems.Add(comment);

		}

		private void btnSaveClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ManagementClosing(object sender, FormClosingEventArgs e)
		{
			JavaList=lwJava.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
			Variants.SaveConfig();
		}

		private void btnDeleteJava_Click(object sender, EventArgs e)
		{
			lwJava.Items.Remove(lwJava.SelectedItems[0]);
		}
	}
}

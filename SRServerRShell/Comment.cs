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
	public partial class Comment : Form
	{
		public Comment()
		{
			InitializeComponent();
		}
		public static string CommentText = "";

		private void Comment_Load(object sender, EventArgs e)
		{

		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Comment_Closing(object sender, FormClosingEventArgs e)
		{
			CommentText = txtBxComment.Text;
		}
	}
}

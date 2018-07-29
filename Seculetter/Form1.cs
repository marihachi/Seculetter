using System;
using System.Windows.Forms;

namespace Seculetter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var senderForm = new SenderForm();
			Hide();
			senderForm.ShowDialog();
			Close();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var receiverForm = new ReceiverForm();
			Hide();
			receiverForm.ShowDialog();
			Close();
		}
	}
}

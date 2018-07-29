using System;
using System.Windows.Forms;

namespace Seculetter
{
	public partial class SenderForm : Form
	{
		public SenderForm()
		{
			InitializeComponent();
		}

		//  encrypt
		private void button2_Click(object sender, EventArgs e)
		{
			using (var rsa = new RSAManager())
			{
				var encrypted = rsa.Encrypt(textBox2.Text, textBox1.Text);
				textBox3.Text = encrypted;
			}
		}

		// open file
		private void button1_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				
			}
		}
	}
}

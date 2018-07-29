using System;
using System.Windows.Forms;

namespace Seculetter
{
	public partial class ReceiverForm : Form
	{
		public ReceiverForm()
		{
			InitializeComponent();
		}

		// create keys
		private void button1_Click(object sender, EventArgs e)
		{
			using (var rsa = new RSAManager())
			{
				var publicKey = rsa.CreatePublicKey();
				textBox1.Text = publicKey;

				var privateKey = rsa.CreatePrivateKey();
				textBox2.Text = privateKey;
			}
		}

		// save keys
		private void button2_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{

			}
		}

		// open file
		private void button3_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{

			}
		}

		// decrypt
		private void button4_Click(object sender, EventArgs e)
		{
			using (var rsa = new RSAManager())
			{
				var decrypted = rsa.Decrypt(textBox4.Text, textBox3.Text);
				textBox5.Text = decrypted;
			}
		}
	}
}

﻿namespace Seculetter
{
	partial class ReceiverForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.tabControl2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage6);
			this.tabControl2.Location = new System.Drawing.Point(9, 9);
			this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(375, 276);
			this.tabControl2.TabIndex = 9;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.button1);
			this.tabPage4.Controls.Add(this.button2);
			this.tabPage4.Controls.Add(this.textBox1);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.textBox2);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(367, 250);
			this.tabPage4.TabIndex = 2;
			this.tabPage4.Text = "1. キーの作成";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 47);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "作成する";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(251, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "ファイルとして保存";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(63, 82);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(295, 19);
			this.textBox1.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "まずは、相手がデータを暗号化できるようにキーを作成しましょう。\r\n公開鍵を教えてあげてください。";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 110);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(43, 12);
			this.label10.TabIndex = 11;
			this.label10.Text = "秘密鍵:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(63, 107);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(295, 19);
			this.textBox2.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 85);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 12);
			this.label11.TabIndex = 12;
			this.label11.Text = "公開鍵:";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label2);
			this.tabPage6.Controls.Add(this.textBox5);
			this.tabPage6.Controls.Add(this.label16);
			this.tabPage6.Controls.Add(this.label17);
			this.tabPage6.Controls.Add(this.textBox3);
			this.tabPage6.Controls.Add(this.label18);
			this.tabPage6.Controls.Add(this.textBox4);
			this.tabPage6.Controls.Add(this.button3);
			this.tabPage6.Controls.Add(this.button4);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(367, 250);
			this.tabPage6.TabIndex = 1;
			this.tabPage6.Text = "2. 復号化";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(359, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "相手から送られてきた「暗号化済みデータ」を秘密鍵を使って復号化します。";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.Location = new System.Drawing.Point(8, 175);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(349, 62);
			this.textBox5.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 160);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 12);
			this.label16.TabIndex = 13;
			this.label16.Text = "復号化済みデータ:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(5, 71);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(94, 12);
			this.label17.TabIndex = 14;
			this.label17.Text = "暗号化済みデータ:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(8, 46);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(314, 19);
			this.textBox3.TabIndex = 10;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 31);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 12);
			this.label18.TabIndex = 15;
			this.label18.Text = "秘密鍵:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(8, 86);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(349, 40);
			this.textBox4.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(326, 44);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(29, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(251, 132);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(106, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "復号化する";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ReceiverForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 298);
			this.Controls.Add(this.tabControl2);
			this.Name = "ReceiverForm";
			this.Text = "受け取る側 - Seculetter";
			this.tabControl2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
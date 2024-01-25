namespace NewApiTestApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			label1 = new Label();
			tbPlayerName = new TextBox();
			tbCardLevel = new TextBox();
			label2 = new Label();
			tbCardNumber = new TextBox();
			label3 = new Label();
			tbPointBalance = new TextBox();
			label4 = new Label();
			tbOrderValue = new TextBox();
			label5 = new Label();
			bProcessOrder = new Button();
			lErrorMessage = new Label();
			listBox1 = new ListBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(12, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(259, 210);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.Location = new Point(307, 38);
			label1.Name = "label1";
			label1.Size = new Size(112, 21);
			label1.TabIndex = 1;
			label1.Text = "Player Name:";
			// 
			// tbPlayerName
			// 
			tbPlayerName.Font = new Font("Segoe UI", 12F);
			tbPlayerName.Location = new Point(425, 35);
			tbPlayerName.Name = "tbPlayerName";
			tbPlayerName.ReadOnly = true;
			tbPlayerName.Size = new Size(256, 29);
			tbPlayerName.TabIndex = 2;
			// 
			// tbCardLevel
			// 
			tbCardLevel.Font = new Font("Segoe UI", 12F);
			tbCardLevel.Location = new Point(425, 70);
			tbCardLevel.Name = "tbCardLevel";
			tbCardLevel.ReadOnly = true;
			tbCardLevel.Size = new Size(256, 29);
			tbCardLevel.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label2.Location = new Point(326, 73);
			label2.Name = "label2";
			label2.Size = new Size(93, 21);
			label2.TabIndex = 3;
			label2.Text = "Card Level:";
			// 
			// tbCardNumber
			// 
			tbCardNumber.Font = new Font("Segoe UI", 12F);
			tbCardNumber.Location = new Point(425, 105);
			tbCardNumber.Name = "tbCardNumber";
			tbCardNumber.ReadOnly = true;
			tbCardNumber.Size = new Size(256, 29);
			tbCardNumber.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label3.Location = new Point(302, 108);
			label3.Name = "label3";
			label3.Size = new Size(117, 21);
			label3.TabIndex = 5;
			label3.Text = "Card Number:";
			// 
			// tbPointBalance
			// 
			tbPointBalance.Font = new Font("Segoe UI", 12F);
			tbPointBalance.Location = new Point(425, 140);
			tbPointBalance.Name = "tbPointBalance";
			tbPointBalance.ReadOnly = true;
			tbPointBalance.Size = new Size(256, 29);
			tbPointBalance.TabIndex = 8;
			tbPointBalance.TextAlign = HorizontalAlignment.Right;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label4.Location = new Point(345, 143);
			label4.Name = "label4";
			label4.Size = new Size(74, 21);
			label4.TabIndex = 7;
			label4.Text = "Balance:";
			// 
			// tbOrderValue
			// 
			tbOrderValue.Font = new Font("Segoe UI", 12F);
			tbOrderValue.Location = new Point(425, 175);
			tbOrderValue.Name = "tbOrderValue";
			tbOrderValue.Size = new Size(256, 29);
			tbOrderValue.TabIndex = 10;
			tbOrderValue.TextAlign = HorizontalAlignment.Right;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label5.Location = new Point(296, 178);
			label5.Name = "label5";
			label5.Size = new Size(123, 21);
			label5.TabIndex = 9;
			label5.Text = "Order Amount:";
			// 
			// bProcessOrder
			// 
			bProcessOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			bProcessOrder.Location = new Point(504, 210);
			bProcessOrder.Name = "bProcessOrder";
			bProcessOrder.Size = new Size(177, 36);
			bProcessOrder.TabIndex = 11;
			bProcessOrder.Text = "PROCESS ORDER";
			bProcessOrder.UseVisualStyleBackColor = true;
			bProcessOrder.Click += bProcessOrder_Click;
			// 
			// lErrorMessage
			// 
			lErrorMessage.AutoSize = true;
			lErrorMessage.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
			lErrorMessage.ForeColor = Color.FromArgb(255, 64, 64);
			lErrorMessage.Location = new Point(302, 309);
			lErrorMessage.Name = "lErrorMessage";
			lErrorMessage.Size = new Size(235, 45);
			lErrorMessage.TabIndex = 12;
			lErrorMessage.Text = "Error Message";
			// 
			// listBox1
			// 
			listBox1.Enabled = false;
			listBox1.Font = new Font("Segoe UI", 12F);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 21;
			listBox1.Location = new Point(12, 265);
			listBox1.Name = "listBox1";
			listBox1.Size = new Size(120, 151);
			listBox1.TabIndex = 13;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label6.Location = new Point(12, 241);
			label6.Name = "label6";
			label6.Size = new Size(92, 21);
			label6.TabIndex = 14;
			label6.Text = "Properties:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1051, 687);
			Controls.Add(label6);
			Controls.Add(listBox1);
			Controls.Add(lErrorMessage);
			Controls.Add(bProcessOrder);
			Controls.Add(tbOrderValue);
			Controls.Add(label5);
			Controls.Add(tbPointBalance);
			Controls.Add(label4);
			Controls.Add(tbCardNumber);
			Controls.Add(label3);
			Controls.Add(tbCardLevel);
			Controls.Add(label2);
			Controls.Add(tbPlayerName);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private TextBox tbPlayerName;
		private TextBox tbCardLevel;
		private Label label2;
		private TextBox tbCardNumber;
		private Label label3;
		private TextBox tbPointBalance;
		private Label label4;
		private TextBox tbOrderValue;
		private Label label5;
		private Button bProcessOrder;
		private Label lErrorMessage;
		private ListBox listBox1;
		private Label label6;
	}
}

namespace Крестики_нолики
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			button8 = new Button();
			button9 = new Button();
			button10 = new Button();
			button11 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.Location = new Point(97, 9);
			label1.Name = "label1";
			label1.Size = new Size(472, 60);
			label1.TabIndex = 0;
			label1.Text = "КРЕСТИКИ-НОЛИКИ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(12, 69);
			label2.Name = "label2";
			label2.Size = new Size(248, 46);
			label2.TabIndex = 1;
			label2.Text = "Ход крестиков";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 28.2F);
			button1.Location = new Point(157, 147);
			button1.Name = "button1";
			button1.Size = new Size(120, 120);
			button1.TabIndex = 2;
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 28.2F);
			button2.Location = new Point(283, 147);
			button2.Name = "button2";
			button2.Size = new Size(120, 120);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 28.2F);
			button3.Location = new Point(409, 147);
			button3.Name = "button3";
			button3.Size = new Size(120, 120);
			button3.TabIndex = 4;
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 28.2F);
			button4.Location = new Point(157, 273);
			button4.Name = "button4";
			button4.Size = new Size(120, 120);
			button4.TabIndex = 5;
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 28.2F);
			button5.Location = new Point(283, 273);
			button5.Name = "button5";
			button5.Size = new Size(120, 120);
			button5.TabIndex = 6;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Font = new Font("Segoe UI", 28.2F);
			button6.Location = new Point(409, 273);
			button6.Name = "button6";
			button6.Size = new Size(120, 120);
			button6.TabIndex = 7;
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button7
			// 
			button7.Font = new Font("Segoe UI", 28.2F);
			button7.Location = new Point(157, 399);
			button7.Name = "button7";
			button7.Size = new Size(120, 120);
			button7.TabIndex = 8;
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Font = new Font("Segoe UI", 28.2F);
			button8.Location = new Point(283, 399);
			button8.Name = "button8";
			button8.Size = new Size(120, 120);
			button8.TabIndex = 9;
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button9
			// 
			button9.Font = new Font("Segoe UI", 28.2F);
			button9.Location = new Point(409, 399);
			button9.Name = "button9";
			button9.Size = new Size(120, 120);
			button9.TabIndex = 10;
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// button10
			// 
			button10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button10.Location = new Point(420, 561);
			button10.Name = "button10";
			button10.Size = new Size(250, 80);
			button10.TabIndex = 11;
			button10.Text = "Новая игра";
			button10.UseVisualStyleBackColor = true;
			button10.Visible = false;
			button10.Click += button10_Click;
			// 
			// button11
			// 
			button11.BackgroundImage = Properties.Resources.Back;
			button11.BackgroundImageLayout = ImageLayout.Stretch;
			button11.ForeColor = SystemColors.ControlText;
			button11.Location = new Point(620, 12);
			button11.Name = "button11";
			button11.Size = new Size(50, 50);
			button11.TabIndex = 12;
			button11.UseVisualStyleBackColor = true;
			button11.Click += button11_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(682, 653);
			Controls.Add(button11);
			Controls.Add(button10);
			Controls.Add(button9);
			Controls.Add(button8);
			Controls.Add(button7);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "Form1";
			Text = "Крестики нолики - Два игрока";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
		private Button button10;
		private Button button11;
	}
}
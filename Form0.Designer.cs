namespace Крестики_нолики
{
	partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            label2.Font = new Font("Segoe UI", 19.8000011F);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(289, 46);
            label2.TabIndex = 1;
            label2.Text = "Выберите режим";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 19.8000011F);
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(250, 100);
            button1.TabIndex = 2;
            button1.Text = "Два игрока";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 19.8000011F);
            button2.Location = new Point(420, 191);
            button2.Name = "button2";
            button2.Size = new Size(250, 100);
            button2.TabIndex = 3;
            button2.Text = "Игра с ботом";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 303);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form0";
            Text = "Крестики-нолики";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
	}
}
namespace lab82
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.b_ball = new System.Windows.Forms.Button();
			this.l_magicans = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// b_ball
			// 
			this.b_ball.BackColor = System.Drawing.SystemColors.HotTrack;
			this.b_ball.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.b_ball.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.b_ball.Location = new System.Drawing.Point(185, 226);
			this.b_ball.Margin = new System.Windows.Forms.Padding(2);
			this.b_ball.Name = "b_ball";
			this.b_ball.Size = new System.Drawing.Size(201, 46);
			this.b_ball.TabIndex = 2;
			this.b_ball.Text = "Что скажет шар?";
			this.b_ball.UseVisualStyleBackColor = false;
			this.b_ball.Click += new System.EventHandler(this.b_ball_Click);
			// 
			// l_magicans
			// 
			this.l_magicans.AutoSize = true;
			this.l_magicans.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.l_magicans.Location = new System.Drawing.Point(110, 328);
			this.l_magicans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.l_magicans.Name = "l_magicans";
			this.l_magicans.Size = new System.Drawing.Size(0, 25);
			this.l_magicans.TabIndex = 3;
			this.l_magicans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(57, 165);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(466, 20);
			this.textBox1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(202, 98);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Введите вопрос:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 521);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.l_magicans);
			this.Controls.Add(this.b_ball);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button b_ball;
		private System.Windows.Forms.Label l_magicans;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}


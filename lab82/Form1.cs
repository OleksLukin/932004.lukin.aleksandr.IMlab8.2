using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab82
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Random rn = new Random();

		public void MagicAns()
		{

			double a = (double)rn.NextDouble();
			double[] A = new double[5];
			string[] phrase = { "Можешь быть уверен в этом", "Хорошие перспективы!", "Пока не ясно, попробуй снова", "Дерзай!", "Даже не думай" };
			A[0] = 0.2;
			for (int i = 1; i < 5; i++)
			{
				A[i] = A[i - 1] + 0.2;
			}
			for (int i = 0; i < 5; i++)
			{
				if ((a - A[i]) < 0)
				{
					l_magicans.Text = phrase[i];
					break;
				}
			}

			if (textBox1.Text == "")
			{
				l_magicans.Text = "Вы не ввели вопрос, я вам ничего не скажу :(";
			}
		}

		private void b_ball_Click(object sender, EventArgs e)
		{
			MagicAns();
		}
	}
}

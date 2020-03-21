using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
	public partial class FrmEslestirKelime : Form
	{
		public FrmEslestirKelime()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			label1.Text = "AT";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = "KEDİ";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = "KÖPEK";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			label1.Text = "KUŞ";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			label1.Text = "İNEK";
		}

		private void button6_Click(object sender, EventArgs e)
		{
			label2.Text = "DOG";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			label2.Text = "COW";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			label2.Text = "BİRD";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			label2.Text = "HORSE";
		}

		private void button10_Click(object sender, EventArgs e)
		{
			label2.Text = "CAT";
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (label1.Text=="KEDİ"&& label2.Text=="CAT")
			{
				button1.Enabled = false;
				button10.Enabled = false;
				button1.BackColor = Color.Yellow;
				button10.BackColor = Color.Yellow;

			}
			if (label1.Text == "KÖPEK" && label2.Text == "DOG")
			{
				button2.Enabled = false;
				button6.Enabled = false;
				button2.BackColor = Color.Yellow;
				button6.BackColor = Color.Yellow;


			}
			if (label1.Text == "AT" && label2.Text == "HORSE")
				{
					button3.Enabled = false;
					button9.Enabled = false;
					button3.BackColor = Color.Yellow;
					button9.BackColor = Color.Yellow;

				}
			if (label1.Text == "KUŞ" && label2.Text == "BİRD")
			{
				button4.Enabled = false;
				button8.Enabled = false;
				button4.BackColor = Color.Yellow;
				button8.BackColor = Color.Yellow;

			}
			if (label1.Text == "İNEK" && label2.Text == "COW")
			{
				button5.Enabled = false;
				button7.Enabled = false;
				button5.BackColor = Color.Yellow;
				button7.BackColor = Color.Yellow;

			}

		}
	}
}

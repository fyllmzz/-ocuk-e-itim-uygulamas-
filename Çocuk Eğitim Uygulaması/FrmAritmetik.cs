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
	public partial class FrmAritmetik : Form
	{
		public FrmAritmetik()
		{
			InitializeComponent();
		}
		Random rastgele = new Random();
		private void label4_Click(object sender, EventArgs e)
		{

		}

		int puan = 0;

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Enabled = false;
			button1.Enabled = true;
			textBox1.Clear();
			int a = rastgele.Next(0, 10);
			int b = rastgele.Next(0, 10);
			int c = rastgele.Next(0, 5);
			label3.Text = a.ToString();
			label4.Text = b.ToString();

			if (c==1)
			{
				label5.Text = "+";

			}
			if (c == 2)
			{
				label5.Text = "-";

			
			}
			if (c == 3)
			{
				label5.Text = "*";

			}
			if (c == 4)
			{
				label5.Text = "/";

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button2.Enabled = true;
			button1.Enabled = false;
			int yanıt;
			if (label5.Text=="+")
			{
				yanıt = Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text);
				LblCveap.Text = yanıt.ToString();
			}
			if (label5.Text == "-")
			{
				yanıt = Convert.ToInt32(label3.Text) - Convert.ToInt32(label4.Text);
				LblCveap.Text = yanıt.ToString();
			}
			if (label5.Text == "*")
			{
				yanıt = Convert.ToInt32(label3.Text) * Convert.ToInt32(label4.Text);
				LblCveap.Text = yanıt.ToString();
			}
			if (label5.Text == "/")
			{
				yanıt = Convert.ToInt32(label3.Text) / Convert.ToInt32(label4.Text);
				LblCveap.Text = yanıt.ToString();
			}
			if (LblCveap.Text == textBox1.Text)
			{
				puan = 10 +puan;
				label6.Text = puan.ToString();
			}
			
		}
	}
}

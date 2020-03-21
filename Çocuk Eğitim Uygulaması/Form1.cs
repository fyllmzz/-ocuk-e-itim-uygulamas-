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
	public partial class FrmAnaForm : Form
	{
		public FrmAnaForm()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			FrmResimler resimler = new FrmResimler();
			resimler.ShowDialog();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			FrmEslestirKelime eslestir = new FrmEslestirKelime();
			eslestir.ShowDialog();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			FrmAritmetik islem = new FrmAritmetik();
			islem.ShowDialog();
		}
	}
}

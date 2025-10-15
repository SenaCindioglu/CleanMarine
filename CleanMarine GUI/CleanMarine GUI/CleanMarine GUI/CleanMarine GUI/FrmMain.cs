using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanMarine_GUI
{

    public partial class Cleanmarine : Form
    {
        FrmManualPage frmManual = new FrmManualPage();
        FrmAutoPage frmAuto = new FrmAutoPage();

        public static DataObject DataObject { get; set; } = new DataObject();


        public Cleanmarine()
        {
            InitializeComponent();

            frmManual.MdiParent = this;

            frmAuto.MdiParent = this;
        }

        private void BtnManual_Click(object sender, EventArgs e)
        {
            frmManual.WindowState = FormWindowState.Maximized;
            frmManual.Show();
            frmAuto.Hide();
            mainPage.Hide();
        }
        private void BtnAuto_Click(object sender, EventArgs e)
        {
            frmAuto.WindowState = FormWindowState.Maximized;
            frmAuto.Show();
            frmManual.Hide();
            mainPage.Hide();
        }
        private void mainPage_Paint(object sender, PaintEventArgs e)
        {
            mainPage.Show();
        }
        private void goBackToMain_Click(object sender, EventArgs e)
        {
            mainPage.Show();
            frmManual.Hide();
            frmAuto.Hide();
        }


		private void RehberButon_Click(object sender, EventArgs e)
		{

		}

		private void Manuelbuton_Click(object sender, EventArgs e)
		{
			frmManual.WindowState = FormWindowState.Maximized;
			frmManual.Show();
			frmAuto.Hide();
			mainPage.Hide();
		}

		private void otonombuton_Click(object sender, EventArgs e)
		{
			frmAuto.WindowState = FormWindowState.Maximized;
			frmAuto.Show();
			frmManual.Hide();
			mainPage.Hide();
		}

		private void RehberButon_MouseEnter(object sender, EventArgs e)
		{
            Cursor = Cursors.Hand;
		}

		private void RehberButon_MouseLeave(object sender, EventArgs e)
		{
			Cursor = Cursors.Default;
		}
	}
}
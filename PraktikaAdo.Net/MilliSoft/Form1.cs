using MilliSoft.Metod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilliSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void formloc(Form frm) {
			foreach (Form item in this.MdiChildren)
			{
				if (!item.IsDisposed && item!=frm)
				{
					item.Close();
				}
}
			if (frm.IsDisposed)
			{

               

            }
			frm.MdiParent = this;

			frm.Show();
			frm.Location = new Point(0, 0);
			}
        
       
        
        
        private void vezifeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VezifeFrom frm = new VezifeFrom();
            formloc(frm);
        }

        private void ısciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsciForm frm = new IsciForm();
            formloc(frm);
		}

        private void xerclerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XerclerForm frm = new XerclerForm();
            formloc(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void derslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DerslerForm frm = new DerslerForm();
            formloc(frm);
        }

        private void telebelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelebeForm frm = new TelebeForm();
            formloc(frm);
        }
    }
}

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
using MilliSoft.Entity;

namespace MilliSoft
{
    public partial class IsciForm : Form
    {
        public IsciForm()
        {
            InitializeComponent();
        }
        IsciMethod iscicmd = new IsciMethod();
        Isci data = new Isci();
        private void IsciForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = iscicmd.Select();
            VezifeMethod vezifecmd = new VezifeMethod();
            comboBox1.DataSource = vezifecmd.Select();
            dataGridView1.Columns[0].Visible = false;
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "Id";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            data.Ad = textBox1.Text;
            data.Soyad = textBox2.Text;
            data.VezifeId = (int)comboBox1.SelectedValue;
            if (iscicmd.Insert(data))
            {
                dataGridView1.DataSource = iscicmd.Select();
                MessageBox.Show("Elave Edildi");
            }
            else
            {
                MessageBox.Show("Elave Edilmedi");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["VezifeAdi"].Value.ToString();          
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            data.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            data.Ad = textBox1.Text;
            data.Soyad = textBox2.Text;
            data.VezifeId = (int)comboBox1.SelectedValue;
            if (iscicmd.Update(data))
            {
                dataGridView1.DataSource = iscicmd.Select();
                MessageBox.Show("Melumat Yenilendi");
            }
            else
            {
                MessageBox.Show("Melumat Yenilenmedi");
            }
            button2.Visible = false;
            button3.Visible = false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            if (MessageBox.Show("Silmek isdediyiniden eminsiniz?", "Melumat Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (iscicmd.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString())))
                {
                    dataGridView1.DataSource = iscicmd.Select();
                    MessageBox.Show("Melumat Silindi");
                }
                else
                {
                    MessageBox.Show("Melumat Silinmedi");
                }
            }

            button2.Visible = false;
            button3.Visible = false;
        }
    }
}

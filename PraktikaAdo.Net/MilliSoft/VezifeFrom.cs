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
    public partial class VezifeFrom : Form
    {
        public VezifeFrom()
        {
            InitializeComponent();
        }
        VezifeMethod cmd = new VezifeMethod();
        Vezife data = new Vezife();

        private void VezifeFrom_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = cmd.Select();
            dataGridView1.Columns[0].Visible = false;
            numericUpDown1.Maximum = 10000000;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaasMiqdar"].Value.ToString());
            button2.Visible = true;
            button3.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.Ad = textBox1.Text;
            data.MaasMiqdar = numericUpDown1.Value;
           
            if (cmd.Insert(data))
            {
                dataGridView1.DataSource = cmd.Select();
                MessageBox.Show("Melumat Elave Olundu");
            }
            else
            {
                MessageBox.Show("Melumat Elave Olunmadi");
            }
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Ad = textBox1.Text;
            data.MaasMiqdar = numericUpDown1.Value;
            if (cmd.Update(data))
            {
                dataGridView1.DataSource = cmd.Select();
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
                if (cmd.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString())))
                {
                    dataGridView1.DataSource = cmd.Select();
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

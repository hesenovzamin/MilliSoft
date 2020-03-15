using MilliSoft.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilliSoft.Metod
{
    public partial class XerclerForm : Form
    {
        public XerclerForm()
        {
            InitializeComponent();
        }
        Xercler data = new Xercler();
        XerclerMethod cmd = new XerclerMethod();
        IsciMethod iscicmd = new IsciMethod();

        private void button1_Click(object sender, EventArgs e)
        {
            data.IsciId = (int)comboBox1.SelectedValue;
            data.Mebleg = numericUpDown1.Value;
            data.Tarix = DateTime.Now;

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

        private void OdenisForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 10000000;
            dataGridView1.DataSource = cmd.Select();         
            comboBox1.DataSource = iscicmd.Select();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = string.Format("select  MaasMiqdar from Isci i inner join Vezife v on i.VezifeId = v.Id where i.Id={0}", (int)comboBox1.SelectedValue);
               ;
                numericUpDown1.Value = int.Parse(Db(sorgu).Rows[0][0].ToString());
            }
            catch (Exception)
            {

               
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            data.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            data.IsciId = (int)comboBox1.SelectedValue;
            data.Mebleg = numericUpDown1.Value;
            data.Tarix = DateTime.Now;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            int b = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IsciId"].Value.ToString());
            string sorgu = string.Format("select x.Id, i.Ad ,x.Mebleg from Xercler x inner join Isci i on i.Id = x.IsciId where x.IsciId ={0} and x.Id={1}",b,a);
            comboBox1.Text = Db(sorgu).Rows[0][1].ToString();
            numericUpDown1.Value =Convert.ToInt32(Db(sorgu).Rows[0][2].ToString());
            cmd.Select();
        }

         DataTable Db(string sorgu)
            {
            DataTable b = new DataTable();
                try
                {
                  
                    SqlDataAdapter adp = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Tools.Connect;
                    cmd.CommandText = sorgu;
                    adp.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                   
                return dt;
                }
                catch (Exception)
                {
                return b;
                }
            }
        
    }
}

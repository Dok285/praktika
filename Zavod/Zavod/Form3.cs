using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavod
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Tip_ypakovki". При необходимости она может быть перемещена или удалена.
            this.tip_ypakovkiTableAdapter.Fill(this.zAVODDataSet1.Tip_ypakovki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Napitok". При необходимости она может быть перемещена или удалена.
            this.napitokTableAdapter.Fill(this.zAVODDataSet1.Napitok);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            napitokBindingSource.EndEdit();
            
            try
            {
                napitokTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipypakovkiBindingSource.EndEdit();
            
            try
            {
                tip_ypakovkiTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}

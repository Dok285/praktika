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
    public partial class postavshikForm7 : Form
    {
        public postavshikForm7()
        {
            InitializeComponent();
        }

        private void postavshikForm7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.zAVODDataSet1.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Postavka_zakaza". При необходимости она может быть перемещена или удалена.
            this.postavka_zakazaTableAdapter.Fill(this.zAVODDataSet1.Postavka_zakaza);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.zAVODDataSet1.Postavshik);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            postavkazakazaBindingSource.EndEdit();
            try
            {
                postavka_zakazaTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.EndEdit();
            try
            {
                postavshikTableAdapter.Update(zAVODDataSet1);
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

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}

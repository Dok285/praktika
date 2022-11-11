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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.zAVODDataSet1.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.pokypka". При необходимости она может быть перемещена или удалена.
            this.pokypkaTableAdapter.Fill(this.zAVODDataSet1.pokypka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.zAVODDataSet1.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Premia". При необходимости она может быть перемещена или удалена.
            this.premiaTableAdapter.Fill(this.zAVODDataSet1.Premia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.finansi". При необходимости она может быть перемещена или удалена.
            this.finansiTableAdapter.Fill(this.zAVODDataSet1.finansi);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finansiBindingSource.EndEdit();
       
            try
            {
                finansiTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokypkaBindingSource.EndEdit();
            try
            {
                pokypkaTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            premiaBindingSource.EndEdit();

            try
            {
                premiaTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

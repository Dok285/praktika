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
    public partial class PostavkaForm6 : Form
    {
        public PostavkaForm6()
        {
            InitializeComponent();
        }

        private void PostavkaForm6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.zAVODDataSet1.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Napitok". При необходимости она может быть перемещена или удалена.
            this.napitokTableAdapter.Fill(this.zAVODDataSet1.Napitok);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.komponent". При необходимости она может быть перемещена или удалена.
            this.komponentTableAdapter.Fill(this.zAVODDataSet1.komponent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.Tehnologia_prigotovlenia". При необходимости она может быть перемещена или удалена.
            this.tehnologia_prigotovleniaTableAdapter.Fill(this.zAVODDataSet1.Tehnologia_prigotovlenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.recept". При необходимости она может быть перемещена или удалена.
            this.receptTableAdapter.Fill(this.zAVODDataSet1.recept);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zAVODDataSet1.proizvodstvo". При необходимости она может быть перемещена или удалена.
            this.proizvodstvoTableAdapter.Fill(this.zAVODDataSet1.proizvodstvo);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proizvodstvoBindingSource.EndEdit();
            try
            {
                proizvodstvoTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            receptBindingSource.EndEdit();
            try
            {
                receptTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tehnologiaprigotovleniaBindingSource.EndEdit();
            try
            {
                tehnologia_prigotovleniaTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            komponentBindingSource.EndEdit();
            try
            {
                komponentTableAdapter.Update(zAVODDataSet1);
                MessageBox.Show("Данные сохранены", "Message");

            }
            catch
            {
                MessageBox.Show("Ошибка сохранения. Первичный ключ используется в другой таблице.");

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                dataGridView4.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                    if (dataGridView4.Rows[i].Cells[j].Value != null)
                        if (dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView4.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}

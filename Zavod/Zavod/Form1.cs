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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Завершить работу программы?",
             "Запрос",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question) == DialogResult.Cancel)

                e.Cancel = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PostavkaForm6 fr6 = new PostavkaForm6();
            fr6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            postavshikForm7 fr7 = new postavshikForm7();
            fr7.Show();
        }
    }
}

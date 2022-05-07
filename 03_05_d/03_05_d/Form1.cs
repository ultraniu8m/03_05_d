using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03_05_d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.CheckBoxes = true;
            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = 0; // установка картинки для файла
                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = String.Format("Вы выбрали: {0}", dateTimePicker1.Value.ToLongTimeString());
        }
    }
}

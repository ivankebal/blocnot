using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blocnot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult rez = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (rez == DialogResult.Yes)
                {
                   


                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.FileName = "Безымянный";
                    sfd.Filter = "Текстовый файл | *txt";

                    
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                        textBox1.Clear();
                    }
                }

                if (rez == DialogResult.No)
                {
                    textBox1.Clear();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые файлы | *txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый файл | *txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
                
            }
        }

         string str;
        
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            str = textBox1.SelectedText.ToString();
          
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str1;
            str1 = str.ToString();
            textBox1.Paste(str1);
        }
    }
}

          

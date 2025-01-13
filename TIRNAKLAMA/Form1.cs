using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIRNAKLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetinAktar();
        }

        private void MetinAktar()
        {        
                string[] satırlar = richTextBox1.Lines;
                richTextBox2.Clear();

                foreach(string satır in satırlar)
                {
                    string donusturulmussatırlar = satır;

                    if (checkBox1.Checked)
                    {
                        donusturulmussatırlar = donusturulmussatırlar.Trim();
                    }
                    if (checkBox2.Checked)
                    {
                        donusturulmussatırlar = "'" + donusturulmussatırlar + "'";
                    }

                    if (checkBox3.Checked)
                    {
                        donusturulmussatırlar = donusturulmussatırlar + ",";
                    }

                    if (checkBox4.Checked)
                    {
                        donusturulmussatırlar = donusturulmussatırlar + ";";
                    }

                richTextBox2.AppendText(donusturulmussatırlar+Environment.NewLine);
                
                }            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox3.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //checkBox1.FlatAppearance.MouseOverBackColor 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string Path = textBox1.Text;

            if (!File.Exists(Path))
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] lines = File.ReadAllLines(Path);
                foreach (var line in lines)
                {
                    textBox2.Text += line + Environment.NewLine;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Path = textBox1.Text;
            if (!File.Exists(Path))
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal TotalExpenses = 0;
                List<string> Categories = new List<string>();
                List<string> Dates = new List<string>();
                string[] lines = File.ReadAllLines(Path);
                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    string num = Convert.ToString(parts[1]);
                    string cont = num.Replace(".", ",");
                    TotalExpenses += decimal.Parse(cont);
                    Categories.Add(parts[2]);
                    Dates.Add(parts[0]);
                }
                textBox2.Text += "Total expenses:" + TotalExpenses + Environment.NewLine;
                textBox2.Text += "Number of categories:" + Categories.Distinct().Count() + Environment.NewLine;
                textBox2.Text += "Total expenses:" + Dates.Distinct().Count() + Environment.NewLine;
            }
        }
    }
}
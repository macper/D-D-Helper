using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLGenerator
{
    public partial class Form1 : Form
    {
        StringBuilder _results; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
            }
            _results = new StringBuilder();
            MessageBox.Show("Zmiana!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _results = new StringBuilder();
            string accounts = System.IO.File.ReadAllText(textBox4.Text);
            string[] accountsArray = accounts.Split('\n');
            StringBuilder elements = new StringBuilder();
            foreach (string account in accountsArray)
            {
                elements.Append(textBox2.Text.Replace("$", account.Trim()));
            }
            _results.AppendLine(textBox1.Text.Replace("$", elements.ToString()));
            textBox3.Text = _results.ToString();
        }
    }
}

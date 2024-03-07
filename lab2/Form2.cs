using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            parent = form1;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.cena_komputera = int.Parse(textBox1.Text)+int.Parse(textBox2.Text);
            parent.textBox3.Text = (parent.cena_komputera + parent.cena_monitora).ToString();
            this.Close();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            textBox1.Text= list[comboBox1.SelectedIndex].ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(400);
            list.Add(500);
            list.Add(600);
            textBox2.Text= list[checkedListBox1.SelectedIndex].ToString();

        }
    }
}

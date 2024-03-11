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
    public partial class Form3 : Form
    {
        private Form1 parent;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form1)
        {
            InitializeComponent ();
            this.parent = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.cena_monitora = int.Parse(textBox1.Text);
            parent.textBox3.Text = (parent.cena_monitora + parent.cena_komputera).ToString();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    if (item.Text == "monitor1")
                        textBox1.Text = 100.ToString();
                    else if (item.Text == "monitor2")
                        textBox1.Text = 200.ToString();
                    else if (item.Text == "monitor3")
                        textBox1.Text = 300.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

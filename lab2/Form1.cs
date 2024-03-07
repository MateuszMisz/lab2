namespace lab2
{
    public partial class Form1 : Form
    {
        public int cena_komputera;
        public int cena_monitora;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}
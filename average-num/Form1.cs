namespace average_num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, n5, avg;
            double.TryParse(textBox1.Text, out n1);
            double.TryParse(textBox2.Text, out n2);
            double.TryParse(textBox3.Text, out n3);
            double.TryParse(textBox4.Text, out n4);
            double.TryParse(textBox5.Text, out n5);
            
            avg = ((n1+n2+n3+n4+n5) / 5);
            label6.Text= avg.ToString();
        }
    }
}
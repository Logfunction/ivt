namespace testFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int r = Convert.ToInt32(textBoxB.Text);
            int d = a - r;
            int h = a + r;
            int v = 0;

            for (int i = d; i <= h; i++)
            {
                textBox4.Text += i + " ";
                v = v + i;
            }
            textBox3.Text = v + "";

            if (v % 2 == 0)
            {
                textBox3.ForeColor = Color.Red;
                textBox3.Text += " sudý souèet";
            }
            else 
            {
                textBox3.Text += " lichý souèet"; 
            }
        }
    }
}
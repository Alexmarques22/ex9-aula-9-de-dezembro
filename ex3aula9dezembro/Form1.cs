namespace ex3aula9dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " e estamos no ano 2022";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hoje é dia 9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "O mes atual é dezembro";

        }
    }
}
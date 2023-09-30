namespace KacanButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random abc = new Random();
            {
                button1.Left = Convert.ToInt32(abc.Next(Size.Width - button1.Width));
                button1.Top = Convert.ToInt32(abc.Next(Size.Height - button1.Height - 40));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You did it!");
        }
    }
}
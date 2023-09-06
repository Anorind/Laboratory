namespace Laboratory
{
    public partial class Form1 : Form
    {
        private Form2 additionalForm;
        public Form1()
        {
            InitializeComponent();
            additionalForm = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            additionalForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            additionalForm.UpdateText(textBox1.Text);
        }
    }
}
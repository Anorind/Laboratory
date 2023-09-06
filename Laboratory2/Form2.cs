using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory2
{
    public partial class Form2 : Form
    {
        public event EventHandler ProductSaved;
        public Product Product { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product.Name = nameTextBox.Text;
                Product.Country = countryTextBox.Text;
                Product.Price = decimal.Parse(priceTextBox.Text);
                ProductSaved?.Invoke(this, EventArgs.Empty);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некоректне число");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            countryTextBox.Clear();
            priceTextBox.Clear();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}

namespace Laboratory2
{
    public partial class Form1 : Form
    {
        private Form2 productForm = new Form2();
        public Form1()
        {
            InitializeComponent();
            productForm.ProductSaved += OnProductSaved;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            productForm.Product = new Product();
            productForm.ShowDialog(this);
        }
        private Product selectedProduct;
        private void editButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItem is Product product)
            {
                selectedProduct = product;
                productForm.Product = product;
                productForm.ShowDialog(this);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItem != null)
            {
                productsListBox.Items.Remove(productsListBox.SelectedItem);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            productsListBox.Items.Clear();
        }
        private void OnProductSaved(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                productsListBox.Items.Remove(selectedProduct);
                selectedProduct = null;
            }
            productsListBox.Items.Add(productForm.Product);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
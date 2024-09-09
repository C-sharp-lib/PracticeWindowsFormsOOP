namespace Encapsulation
{
    public partial class ProductMaintenance : Form
    {
        public ProductMaintenance()
        {
            InitializeComponent();
        }

        private void ProductMaintenance_Load(object sender, EventArgs e)
        {
            var productsFromDatabase = ProductService.GetProducts();
            foreach (var product in productsFromDatabase.ToList()) 
            { 
                lstProducts.Items.Add(product.GetDisplayText(","));
            }
            
        }
    }
}

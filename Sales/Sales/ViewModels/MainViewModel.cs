namespace Sales.ViewModels
{
    public class MainViewModel
    {
        public ProductsViewModel Prooducts { get; set; }

        public MainViewModel()
        {
            this.Prooducts = new ProductsViewModel();
        }
    }
}

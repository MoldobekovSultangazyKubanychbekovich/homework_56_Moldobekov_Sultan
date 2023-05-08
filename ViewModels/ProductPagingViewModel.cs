using home_56.Models;

namespace home_56.ViewModels
{
    public class ProductPagingViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}

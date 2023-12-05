using PustokMVC.Models;

namespace PustokMVC.ViewModels.ProductVM
{
    public class ProductCreateVM
    {
        public int Id { get; set; }
        public List<ProductImages> ProductImages { get; set; }
        public string ProductCode { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public bool? isDeleted { get; set; }
    }
}

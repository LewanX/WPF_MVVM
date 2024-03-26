using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WPF_Practice2.Services.Products;

namespace WPF_Practice2.Model
{
    public class ProductViewModel
    {
        
        public ObservableCollection<Product> Products { get; set; }
        ProductService productService = new ProductService();
        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
       
        }
        public void LoadProducts()
        {
            Products = productService.GetAllAsync().Result;
          
       }
    }
}

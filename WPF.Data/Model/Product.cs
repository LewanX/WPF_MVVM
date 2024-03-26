using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Practice2.Model
{
    public class Product
    {

        public Product()
        {
            
        }
        public Product(int id, string name, string description, decimal? price, string category, string imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            ImageUrl = imageUrl;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }    

    }
}

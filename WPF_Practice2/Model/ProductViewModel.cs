using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WPF_Practice2.Model
{
    public class ProductViewModel
    {
        private readonly string DbConnectionString = "Data Source=DESKTOP-5L3JTLB;Initial Catalog=ElAlmacén;Integrated Security=True;Pooling=False;Encrypt=False";

        public ObservableCollection<Product> Products { get; set; }
        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
           
        }
        public void LoadProducts()
        {
            const string queryString =
                "SELECT [Id],[Name], [Description], [Price], [Category], [ImageUrl] FROM dbo.Product"; // Include square brackets for reserved keywords

            using (SqlConnection connection = new SqlConnection(DbConnectionString))
            {
                
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening connection: {0}", ex.Message);
                    return; 
                }

              
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            
                            Product product = new Product
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Price = reader.GetDecimal(3), 
                                Category = reader.GetString(4),
                                ImageUrl = reader.GetString(5),
                            };

                            
                            Products.Add(product);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing query: {0}", ex.Message);
                    
                }
            }
        }
    }
}

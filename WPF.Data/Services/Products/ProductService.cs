using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Practice2.Model;

namespace WPF_Practice2.Services.Products
{
    public class ProductService : IDataService<Product>
    {
        private readonly string DbConnectionString = "Data Source=DESKTOP-5L3JTLB;Initial Catalog=ElAlmacén;Integrated Security=True;Pooling=False;Encrypt=False";

        public Task<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<Product>> GetAllAsync()
        {
            const string queryString = "SELECT [Id], [Name], [Description], [Price], [Category], [ImageUrl] FROM dbo.Product";

            using (SqlConnection connection = new SqlConnection(DbConnectionString))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync()) 
                    {
                        List<Product> products = new List<Product>();

                        while (await reader.ReadAsync()) 
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

                            products.Add(product);
                        }

                        return new ObservableCollection<Product>(products);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving products: {0}", ex.Message);
                    throw; 
                }
            }
        }

        public Task<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product typeClass)
        {
            throw new NotImplementedException();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Teste.entities;
using Teste.enu;
using Teste.Errors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Teste.DataAccessObject.Product
{
    public class ProductDAO
    {

        public static async Task InsertProductAsync(entities.Product product)
        {
            IsValid(product);
            int type = int.Parse(product.Invtype.ToString());
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string insertQuery = "INSERT INTO products (name, description, invtype, price, quant) VALUES (@Name, @Description, @Invtype, @Price ,@Quant)";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@InvType", type);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Quant", product.Quant);

                await command.ExecuteNonQueryAsync();
            }
        }
        public async Task DeleteProductAsync(int productId)
        {

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string deleteQuery = "DELETE FROM produtos WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateProductAsync(entities.Product product)
        {
            IsValid(product);
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string updateQuery = "UPDATE produtos SET name = @Name, description = @Description, category_id = @CategoryId, price = @Price WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                //  command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@ProductId", product.Id);

                await command.ExecuteNonQueryAsync();
            }


        }

        public static async Task<List<entities.Product>> GetAllAsync()
        {
            List<entities.Product> productList = new List<entities.Product>();

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT id, name, description, invtype, price, quant FROM products";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        entities.Product product = new entities.Product
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Description = reader["description"].ToString(),
                            Price = double.Parse(reader["Price"].ToString()),
                            Quant = int.Parse(reader["quant"].ToString()),
                            Invtype = (enu.InvType.investorType)reader["InvType"]
                        };

                        productList.Add(product);
                    }
                }
            }

            return productList;
        }

        public async Task<entities.Product> GetProductByNameAsync(string productName)
        {
            entities.Product product = null;
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT id, name, description, category_id, price FROM produtos WHERE name ILIKE @ProductName LIMIT 1";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductName", "%" + productName + "%");

                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                      /*  product = new entities.Product(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3),
                            reader.GetDouble(4),
                            reader.GetInt32(5));*/
                    }
                }
            }



            return product;
        }

        private static void IsValid(entities.Product product)
        {

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                throw new InvalidEntityException(typeof(entities.Product), "Forneça o nome");
                ;
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                throw new InvalidEntityException(typeof(entities.Product), "Forneça a descrição");
            }



            if (product.Price <= 0)
            {
                throw new InvalidEntityException(typeof(entities.Product), "Forneça o preço");
            }

        }
    }
}


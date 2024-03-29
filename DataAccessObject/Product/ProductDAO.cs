﻿using Npgsql;
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
            int type = (int)product.Invtype;
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
        public static async Task UpdateAsync(entities.Product product)
        {
            IsValid(product);

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string updateQuery = "UPDATE products SET name = @Name, description = @Description, invtype = @Invtype, price = @Price, quant = @Quant WHERE id = @Id";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Invtype", (int)product.Invtype);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Quant", product.Quant);

                await command.ExecuteNonQueryAsync();
            }
        }
        public static async Task DeleteProductAsync(int productId)
        {

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string deleteQuery = "DELETE FROM products WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                await command.ExecuteNonQueryAsync();
            }
        }

        public static async Task<entities.Product> GetByIdAsync(int productId)
        {
            entities.Product product = null;

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT id, name, description, invtype, price, quant FROM products WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        product = new entities.Product
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Description = reader["description"].ToString(),
                            Price = double.Parse(reader["Price"].ToString()),
                            Quant = int.Parse(reader["quant"].ToString()),
                            Invtype = (enu.InvType.investorType)reader["InvType"]
                        };
                    }
                }
            }

            return product;
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

        public static async Task<entities.Product> GetByNameAsync(string name)
        {
            entities.Product product = null;

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT id, name, description, invtype, price, quant FROM products WHERE name = @Name";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        product = new entities.Product
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = reader["name"].ToString(),
                            Description = reader["description"].ToString(),
                            Price = double.Parse(reader["Price"].ToString()),
                            Quant = int.Parse(reader["quant"].ToString()),
                            Invtype = (enu.InvType.investorType)reader["InvType"]
                        };
                    }
                }
            }

            return product;
        }

        public static async Task UpdateProductQuantityAsync(int productId, int quantityToSubtract)
        {
            int currentQuantity = await GetProductQuantityAsync(productId);

            int newQuantity = currentQuantity - quantityToSubtract;

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string updateQuery = "UPDATE products SET quant = @Quantity WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Quantity", newQuantity);
                command.Parameters.AddWithValue("@ProductId", productId);

                await command.ExecuteNonQueryAsync();
            }
        }

        private static async Task<int> GetProductQuantityAsync(int productId)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT quant FROM products WHERE id = @ProductId";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@ProductId", productId);

                object result = await command.ExecuteScalarAsync();
                int currentQuantity = Convert.ToInt32(result);
                return currentQuantity;
            }
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


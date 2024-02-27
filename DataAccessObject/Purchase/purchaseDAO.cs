using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.entities;

namespace Teste.DataAccessObject.Purchase
{
    public static class purchaseDAO
    {
        public static async Task InserirCompraAsync(Compra compra)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string insertCompraQuery = "INSERT INTO Compra (ClienteId) VALUES (@ClienteId) RETURNING Id";

            using (NpgsqlCommand command = new NpgsqlCommand(insertCompraQuery, connection))
            {
                command.Parameters.AddWithValue("@ClienteId", compra.ClienteId);

                int compraId = (int)await command.ExecuteScalarAsync();

                foreach (var item in compra.ItemDaCompras)
                {
                    string insertItemQuery = "INSERT INTO ItemDaCompra (CompraId, ProdutoId, Quantidade, ValorPagoPorUnidade) VALUES (@CompraId, @ProdutoId, @Quantidade, @ValorPagoPorUnidade)";

                    using (NpgsqlCommand itemCommand = new NpgsqlCommand(insertItemQuery, connection))
                    {
                        itemCommand.Parameters.AddWithValue("@CompraId", compraId);
                        itemCommand.Parameters.AddWithValue("@ProdutoId", item.ProdutoId);
                        itemCommand.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                        itemCommand.Parameters.AddWithValue("@ValorPagoPorUnidade", item.ValorPagoPorUnidade);

                        await itemCommand.ExecuteNonQueryAsync();
                    }
                }

                connection.Close();
            }
        }

        public static async Task<Compra> GetPurchaseByClientIdAsync(int clientId)
        {
            Compra compra = null;

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT * FROM Compra WHERE ClienteId = @ClienteId";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@ClienteId", clientId);

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    compra = new Compra
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ClienteId = Convert.ToInt32(reader["ClienteId"]),
                        Compra_aprovada = Convert.ToBoolean(reader["compra_aprovada"]),
                        ItemDaCompras = new List<ItemDaCompra>()
                    };

                    reader.Close();

                    string selectItemsQuery = "SELECT * FROM ItemDaCompra WHERE CompraId = @CompraId";

                    using (NpgsqlCommand itemCommand = new NpgsqlCommand(selectItemsQuery, connection))
                    {
                        itemCommand.Parameters.AddWithValue("@CompraId", compra.Id);

                        NpgsqlDataReader itemReader = await itemCommand.ExecuteReaderAsync();

                        while (await itemReader.ReadAsync())
                        {
                            ItemDaCompra item = new ItemDaCompra
                            {
                                Id = Convert.ToInt32(itemReader["Id"]),
                                CompraId = Convert.ToInt32(itemReader["CompraId"]),
                                ProdutoId = Convert.ToInt32(itemReader["ProdutoId"]),
                                Quantidade = Convert.ToInt32(itemReader["Quantidade"]),
                                ValorPagoPorUnidade = Convert.ToDecimal(itemReader["ValorPagoPorUnidade"])
                            };

                            compra.ItemDaCompras.Add(item);
                        }

                        itemReader.Close();
                    }
                }
                else
                {
                    reader.Close();
                }
            }

            connection.Close();

            return compra;
        }

        public static async Task<List<Compra>> GetUnapprovedPurchasesAsync()
        {
            List<Compra> compras = new List<Compra>();

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT * FROM Compra WHERE compra_aprovada = false";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Compra compra = new Compra
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        ClienteId = Convert.ToInt32(reader["ClienteId"]),
                        Compra_aprovada = Convert.ToBoolean(reader["compra_aprovada"]),
                        ItemDaCompras = new List<ItemDaCompra>()
                    };

                    string selectItemsQuery = "SELECT * FROM ItemDaCompra WHERE CompraId = @CompraId";

                    using (NpgsqlCommand itemCommand = new NpgsqlCommand(selectItemsQuery, connection))
                    {
                        itemCommand.Parameters.AddWithValue("@CompraId", compra.Id);

                        NpgsqlDataReader itemReader = await itemCommand.ExecuteReaderAsync();

                        while (await itemReader.ReadAsync())
                        {
                            ItemDaCompra item = new ItemDaCompra
                            {
                                Id = Convert.ToInt32(itemReader["Id"]),
                                CompraId = Convert.ToInt32(itemReader["CompraId"]),
                                ProdutoId = Convert.ToInt32(itemReader["ProdutoId"]),
                                Quantidade = Convert.ToInt32(itemReader["Quantidade"]),
                                ValorPagoPorUnidade = Convert.ToDecimal(itemReader["ValorPagoPorUnidade"])
                            };

                            compra.ItemDaCompras.Add(item);
                        }

                        itemReader.Close();
                    }

                    compras.Add(compra);
                }

                reader.Close();
            }

            connection.Close();

            return compras;
        }
    }
}


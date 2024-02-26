using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Teste.entities;
using Teste.Errors;

namespace Teste.DataAccessObject.Client
{
    public class ClientDAO
    {
        public static async Task InsertClientAsync(entities.Client client)
        {

            IsValidAsync(client);

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string insertQuery = "INSERT INTO clients (name, email, cpf, gender, phone, access_id, wallet, investor_type) VALUES (@Name, @Email, @Cpf, @Gender, @Phone, @AccessId, @Wallet, @InvestorType)";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@Email", client.Email);
                command.Parameters.AddWithValue("@Cpf", client.Cpf);
                command.Parameters.AddWithValue("@Gender", client.Gender);
                command.Parameters.AddWithValue("@Phone", client.Phone);
                command.Parameters.AddWithValue("@AccessId", client.AccessId);
                command.Parameters.AddWithValue("@Wallet", client.Wallet);
                command.Parameters.AddWithValue("@InvestorType", (int)client.Type);

                await command.ExecuteNonQueryAsync();

                connection.Close();
            }
        }

        public static async Task<entities.Client> GetByNameAsync(string name)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT * FROM clients WHERE name = @Name";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", name);

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    entities.Client client = new entities.Client
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Email = reader["email"].ToString(),
                        Cpf = reader["cpf"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Phone = reader["phone"].ToString(),
                        AccessId = Convert.ToInt32(reader["access_id"]),
                        Wallet = float.Parse(reader["wallet"].ToString()),
                        Type = (enu.InvType.investorType)(reader["investor_type"])
                    };

                    reader.Close();
                    connection.Close();

                    return client;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return null;
                }
            }
        }

        public static async Task DeleteClientAsync(int clientId)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string deleteQuery = "DELETE FROM clients WHERE id = @ClientId";

            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ClientId", clientId);
                await command.ExecuteNonQueryAsync();
            }
        }
        public static async Task<List<entities.Client>> GetAllAsync()
        {
            List<entities.Client> clients = new List<entities.Client>();

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT * FROM clients";

            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                NpgsqlDataReader reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    entities.Client client = new entities.Client
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Email = reader["email"].ToString(),
                        Cpf = reader["cpf"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Phone = reader["phone"].ToString(),
                        AccessId = Convert.ToInt32(reader["access_id"]),
                        Wallet = float.Parse(reader["wallet"].ToString()),
                        Type = (enu.InvType.investorType)(reader["investor_type"])
                    };

                    clients.Add(client);
                }

                reader.Close();
            }
            connection.Close();
            return clients;
        }

        public static async Task<entities.Client> GetByAccessIdAsync(int accessId)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string selectQuery = "SELECT * FROM clients WHERE access_id = @AccessId";
            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@AccessId", accessId);
                NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    entities.Client client = new entities.Client
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Name = reader["name"].ToString(),
                        Email = reader["email"].ToString(),
                        Cpf = reader["cpf"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Phone = reader["phone"].ToString(),
                        AccessId = Convert.ToInt32(reader["access_id"]),
                        Wallet = float.Parse(reader["wallet"].ToString()),
                        Type = (enu.InvType.investorType)(reader["investor_type"])
                    };
                    reader.Close();
                    connection.Close();

                    return client;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return null;
                }
            }
        }
        public static async Task AddToWalletAsync(int clientId, float amountToAdd)
        {

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string updateQuery = "UPDATE clients SET wallet = wallet + @AmountToAdd WHERE id = @ClientId";

            using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@AmountToAdd", amountToAdd);
                command.Parameters.AddWithValue("@ClientId", clientId);

                await command.ExecuteNonQueryAsync();
            }


        }



        private static async Task IsValidAsync(entities.Client client)
        {
            if (string.IsNullOrWhiteSpace(client.Name))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Forneça o nome");
            }

            if (string.IsNullOrWhiteSpace(client.Email))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Forneça um email para contato");
            }

            if (string.IsNullOrWhiteSpace(client.Cpf))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Forneça o CPF");
            }

            if (string.IsNullOrWhiteSpace(client.Gender))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Sexo é um campo obrigatorio"); ;
            }

            if (string.IsNullOrWhiteSpace(client.Phone))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Forneça um telefone para contato");
            }



            if (client.Wallet <= 0)
            {
                throw new InvalidEntityException(typeof(entities.Access), "Saldo precisa ser maior que 0");
            }


        }
    }
}
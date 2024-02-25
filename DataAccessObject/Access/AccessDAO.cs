using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Threading.Tasks;
using Teste.Errors;
using Teste.utils;

namespace Teste.DataAccessObject.Access
{
    public class AccessDAO
    {
        public static async Task<int> InsertAccessAsync(entities.Access access)
        {

            IsValid(access);

            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();

            int idInserido = 0;
            access = Crip.EncryptAccessAsync(access);
            string insertQuery = "INSERT INTO access (username, password, isAdmin) VALUES (@User, @Password, @IsAdmin) RETURNING id";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@User", access.User);
                command.Parameters.AddWithValue("@Password", access.Password);
                command.Parameters.AddWithValue("@IsAdmin", access.IsAdmin);

                idInserido = (int)command.ExecuteScalar();
                

            }
            return idInserido;

        }

        public async Task DeleteAccessAsync(int accessId)
        {
            NpgsqlConnection connection = await DbConection.DbConection.GetConnectionAsync();
            string deleteQuery = "DELETE FROM access WHERE id = @AccessId";

            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@AccessId", accessId);

                await command.ExecuteNonQueryAsync();
            }

        }

        private static void IsValid(entities.Access access)
        {
            if (string.IsNullOrEmpty(access.User))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Usuario não pode ser nulo");
            }

            if (string.IsNullOrEmpty(access.Password))
            {
                throw new InvalidEntityException(typeof(entities.Access), "Password não pode ser nulo");
            }

        }
    }
}
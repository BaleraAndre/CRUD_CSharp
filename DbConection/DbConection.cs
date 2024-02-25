using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.DbConection
{
    public static class DbConection
    {
        public static async Task<NpgsqlConnection> GetConnectionAsync()
        {
            NpgsqlConnection connection = null;

            string connectionString = $"Server=localhost;Port=5432;Database=teste_db;User ID=postgres;Password=03021955";

            try
            {
                connection = new NpgsqlConnection(connectionString);
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar conectar ao banco de dados PostgreSQL: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection = null;
            }

            return connection;
        }

    }
}

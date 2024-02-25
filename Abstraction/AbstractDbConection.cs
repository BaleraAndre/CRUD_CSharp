using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Abstraction
{
    public abstract class AbstractDbConection
    {
       public abstract NpgsqlConnection ObterConexao();
    }
}

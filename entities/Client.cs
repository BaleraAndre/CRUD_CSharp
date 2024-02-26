using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.enu.InvType;

namespace Teste.entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Cpf { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int AccessId { get; set; }
        public float Wallet { get; set; }

        public investorType  Type { get; set; }
    }
}

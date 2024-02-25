using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Teste.enu.InvType;

namespace Teste.entities
{
    public class Product
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public investorType Invtype { get; set; }
        public double Price { get; set; }

        public int Quant {  get; set; }

        
    }
}

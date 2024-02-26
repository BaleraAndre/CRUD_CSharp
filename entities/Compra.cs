using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.entities
{
    public class Compra
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public List<ItemDaCompra> ItemDaCompras { get; set; } = new List<ItemDaCompra>();




    }

    public class ItemDaCompra 
    {
        public int Id { get; set; }

        public int CompraId { get; set; }

        public int ProdutoId { get; set; }

        public int Quantidade { get; set; }

        public decimal ValorPagoPorUnidade { get; set; }
    }
}

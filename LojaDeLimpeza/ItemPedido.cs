using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class ItemPedido
    {
        public int IdItemPedido { get; set; }

        public int QuantidadeProduto { get; set; }

        public Produto Produto { get; set; }
    }
}

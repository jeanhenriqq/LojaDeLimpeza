using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Pedido
    {
        public int IdPedido { get; set; }

        public DateTime DataPedido { get; set; }

        public Cliente Cliente { get; set; }

        public IList<string> ListaDeItemPedido = new List<string>();

        public IList<string> ListaDePedido = new List<string>();
    }
}

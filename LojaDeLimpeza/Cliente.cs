using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Cliente
    {
        public int IdCliente { get; set; }

        public string NomeCliente { get; set; }

        public string CPF { get; set; }

        public string Filiacao { get; set; }

        public Contato Contato { get; set; }

        public Endereco Endereco { get; set; }

        public IList<string> ListaDeCliente = new List<string>();
    }
}

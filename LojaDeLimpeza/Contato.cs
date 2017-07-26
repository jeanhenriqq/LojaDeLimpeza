using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Contato
    {
        public string NomeContato { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public IList<string> ListaDeTelefone { get; set; }
    }
}

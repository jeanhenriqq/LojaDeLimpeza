using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Fornecedor
    {
        public int IdFornecedor { get; set; }

        public string CNPJ { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public IList<string> ListaDeForncedor = new List<string>();
    }
}

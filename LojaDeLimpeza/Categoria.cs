using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Categoria
    {
        public int IdCategoria { get; set; }

        public string NomeCategoria { get; set; }

        public IList<string> ListaDeCategoria = new List<string>();

        public Categoria(int idCategoria, string nomeCategoria)
        {
            this.IdCategoria = idCategoria;
            this.NomeCategoria = nomeCategoria;
        }
    }
}

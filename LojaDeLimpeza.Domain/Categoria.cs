using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Categoria
    {
        #region
        public int Id { get; set; }
        public string Nome { get; set; }
        #endregion

        #region constructor
        public Categoria(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        #endregion

        #region methods
        #endregion
    }
}

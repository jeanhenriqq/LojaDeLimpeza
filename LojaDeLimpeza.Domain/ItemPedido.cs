using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class ItemDePedido
    {
        #region properties
        private int id;
        private Produto produto;
        private int quantidade;
        private decimal totalItem;

        public int Id { get { return this.id; } }
        public Produto Produto { get { return this.produto; } }
        public int Quantidade { get { return this.quantidade; } }
        public decimal TotalItem { get { return this.totalItem; } }
        #endregion


    }
}

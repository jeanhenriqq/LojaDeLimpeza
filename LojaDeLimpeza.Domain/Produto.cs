using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza.Domain
{
    public class Produto
    {
        #region properties
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }


        #endregion

        #region methods
        public void AdcionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEmEstoque += quantidade;
            }
            else
            {
                throw new Exception("Quantidade deve ser maior do que zero");
            }
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                this.QuantidadeEmEstoque -= quantidade;
            }
            else
            {
                throw new Exception("Quantidade deve ser maior do que zero");
            }
        }
        
        #endregion
    }
}

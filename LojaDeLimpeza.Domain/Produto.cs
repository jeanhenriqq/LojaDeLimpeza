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
        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }


        #endregion

        #region constructor
        public Produto(int id, string nome, DateTime dataFabricacao, Categoria categoria, decimal preco, int quantidadeEmEstoque)
        {

            ValidaPreco(preco);
            ValidaQuantidadeEmEstoque(quantidadeEmEstoque);

            this.Id = id;
            this.Nome = nome;
            this.DataFabricacao = dataFabricacao;
            this.Categoria = categoria;
            this.Preco = preco;
            this.QuantidadeEmEstoque = quantidadeEmEstoque;
        }

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

        private bool ValidaPreco(decimal preco)
        {
            if( preco > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("O preço deve ser maior do que zero");
            }
        }
        
        private bool ValidaQuantidadeEmEstoque(int quantidadeEmEstoque)
        {
            if(quantidadeEmEstoque > 0)
            {
                return true;
            }
            else
            {
                throw new Exception("A quantidade deve ser maior do que zero");
            }
        }
        #endregion
    }
}

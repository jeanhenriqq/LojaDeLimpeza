using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDeLimpeza
{
    class Produto
    {
        public int IdProduto { get; set; }
        
        public string NomeProduto { get; set; }

        public DateTime DataFabricacao { get; set; }

        public DateTime DataValidacao { get; set; }

        public int QuantidadeEmEstoque { get; set; }

        public IList<Categoria> Categoria { get; set; }

        IList<Produto> ListaDeProdutos = new List<Produto>();
        
        public Produto(Produto produto, int idProduto, string nomeProduto, DateTime dataFabricacao, DateTime dataValidacao, int quantidadeEmEstoque)
        {
            this.IdProduto = idProduto;
            this.NomeProduto = nomeProduto;
            this.DataFabricacao = dataFabricacao;
            this.DataValidacao = dataFabricacao;
            this.QuantidadeEmEstoque = quantidadeEmEstoque;
            this.ListaDeProdutos.Add(produto);
        }

        public void SelecionaCategoria()
        {

        }
    }
}

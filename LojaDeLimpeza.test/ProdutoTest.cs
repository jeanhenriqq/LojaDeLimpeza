using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.test
{
    [TestClass]
    public class ProdutoTest
    {
        #region Object
        Categoria categoria;
        Produto produto;

        public ProdutoTest()
        {
            categoria = new Domain.Categoria(1, "Cozinha");

            produto = new Domain.Produto(1, "Palha de aço", new DateTime(2017, 07, 17), categoria, 10, 10)
            {
                DataValidade = new DateTime()
            };
        } 

        #endregion

        #region Test
        [TestMethod]
        public void TestAdicionarEstoque()
        {
            produto.AdcionarEstoque(5);

            Assert.AreEqual(15, produto.QuantidadeEmEstoque);
        }

        [TestMethod]
        public void TestRemoverEstoque()
        {
            produto.RemoverEstoque(5);

            Assert.AreEqual(5, produto.QuantidadeEmEstoque);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ser maior do que zero")]
        public void TestRemoverEstoqueValorNegativo()
        {
             produto.RemoverEstoque(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ser maior do que zero")]
        public void TestRemoverEstoqueValorZero()
        {
            produto.RemoverEstoque(0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ser maior do que zero")]
        public void TestAdicionarEstoqueValorNegativo()
        {
            produto.AdcionarEstoque(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ser maior do que zero")]
        public void TestAdicionarEstoqueValorZero()
        {
            produto.AdcionarEstoque(0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "O preço deve ser maior do que R$ 0.00")]
        public void TestValidaPrecoValorZero()
        {
            produto = new Produto(1, "", DateTime.Now.Date, categoria, -1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "A quantidade deve ser maior do que zero")]
        public void TestValidaEstoqueValorZero()
        {
            produto = new Produto(1, "", DateTime.Now.Date, categoria, 1, -1);
        }

        #endregion
    }
}

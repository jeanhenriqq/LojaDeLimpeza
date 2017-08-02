using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDeLimpeza.Domain;

namespace LojaDeLimpeza.test
{
    [TestClass]
    public class ProdutoTest
    {
        Produto produto = new Domain.Produto()
        {
            Id = 1,
            Nome = "Palha de aço",
            QuantidadeEmEstoque = 10
        };

        [TestMethod]
        public void TestAdicionarEstoque()
        {
            
            produto.AdcionarEstoque(5);

            Assert.AreEqual(produto.QuantidadeEmEstoque, 15);
        }

        [TestMethod]
        public void TestRemoverEstoque()
        {
            
            produto.RemoverEstoque(5);

            Assert.AreEqual(produto.QuantidadeEmEstoque, 5);
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
    }
}

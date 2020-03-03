using EntityBase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ClienteTest
    {
        Cliente cliente;

        [SetUp]
        public void Setup()
        {
            cliente = new Cliente(DateTime.Now, DateTime.Now, "Ciro", "Batista");
        }

        [Test]
        public void DeveCriarClienteComSucesso()
        {
            cliente = new Cliente(DateTime.Now, DateTime.Now, "João", "Dos Santos");
            Assert.Pass();
        }

        [Test]
        public void DeveRetornarNomeCompleto()
        {
            StringAssert.Contains("Ciro Batista", cliente.NomeCompleto);
        }
    }
}
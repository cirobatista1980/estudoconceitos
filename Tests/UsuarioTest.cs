using EntityBase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class UsuarioTest
    {
        Usuario usuario;

        [SetUp]
        public void Setup()
        {
            usuario = new Usuario(DateTime.Now, DateTime.Now, "login", "senha");
        }

        [Test]
        public void DeveCriarUsuarioComSucesso()
        {
            usuario = new Usuario(DateTime.Now, DateTime.Now, "login", "senha");
            Assert.Pass();
        }

    }
}
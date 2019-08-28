using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TutorialEcommerce.Domain.Entities;
using TutorialEcommerce.Domain.ValueObject;

namespace TutorialEcommerce.Domain.Tests.Entities
{
    [TestClass]
    public class UsuarioTests
    {
        private Cpf Cpf { get; set; }
        private Email Email { get; set; }
        private string Login { get; set; }
        private string Senha { get; set; }
        private string SenhaConfirmacao { get; set; }

        public UsuarioTests()
        {
            Cpf = new Cpf("564.629.048-10");
            Email = new Email("email@email.com");
            Login = "adminteste";
            Senha = "123456";
            SenhaConfirmacao = "123456";
        }

        [TestMethod]
        public void Novo_Usuario_Cpf()
        {
            var usuario = new Usuario(Login, Cpf, Email, Senha, SenhaConfirmacao);
            Assert.AreEqual(Cpf, usuario.Cpf);
        }

        [TestMethod]
        public void Novo_Usuario_Login()
        {
            var usuario = new Usuario(Login, Cpf, Email, Senha, SenhaConfirmacao);
            Assert.AreEqual(Login, usuario.Login);
        }

        [TestMethod]
        public void Novo_Usuario_Email()
        {
            var usuario = new Usuario(Login, Cpf, Email, Senha, SenhaConfirmacao);
            Assert.AreEqual(Email, usuario.Email);
        }

        [TestMethod]
        public void Novo_Usuario_Senha()
        {
            var usuario = new Usuario(Login, Cpf, Email, Senha, SenhaConfirmacao);
            Assert.IsNotNull(usuario.Senha);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Novo_Usuario_Cpf_Obrigatorio()
        {
            new Usuario(Login, null, Email, Senha, SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Novo_Usuario_Login_Obrigatorio()
        {
            new Usuario("", Cpf, Email, Senha, SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Novo_Usuario_Email_Obrigatorio()
        {
            new Usuario(Login, Cpf, null, Senha, SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Novo_Usuario_Senha_Obrigatorio()
        {
            new Usuario(Login, Cpf, Email, "", SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Novo_Usuario_SenhaConfirmacao_Obrigatorio()
        {
            new Usuario(Login, Cpf, Email, Senha, "");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_Senha_MinValue()
        {
            var senha = "123";
            new Usuario(Login, Cpf, Email, senha, senha);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_Senha_MaxValue()
        {
            var senha = "1234567891234567890123456789012";
            new Usuario(Login, Cpf, Email, senha, senha);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_Login_MinValue()
        {
            var login = "admin";
            new Usuario(login, Cpf, Email, Senha, SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_Login_MaxValue()
        {
            var login = "1234567891234567890123456789012";
            new Usuario(login, Cpf, Email, Senha, SenhaConfirmacao);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Usuario_Senhas_Nao_Conferem()
        {
            new Usuario(Login, Cpf, Email, "blablabla", "patatipatata");
        }

    }
}

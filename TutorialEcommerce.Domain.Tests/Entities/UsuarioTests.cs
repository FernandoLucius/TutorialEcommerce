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
            Cpf = new Cpf("564.629.048 - 10");
            Email = new Email("email@email.com");
            Login = "admin";
            Senha = "123456";
            SenhaConfirmacao = "123456";
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

    }
}

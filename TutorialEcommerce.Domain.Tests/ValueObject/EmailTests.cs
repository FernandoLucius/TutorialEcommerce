using Microsoft.VisualStudio.TestTools.UnitTesting;
using TutorialEcommerce.Domain.ValueObject;
using System;

namespace TutorialEcommerce.Domain.Tests.ValueObject
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void New_Email_Em_Branco()
        {
            var email = new Email("");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void New_Email_Null()
        {
            var email = new Email(null);
        }

        [TestMethod]
        public void New_Email_Valido()
        {
            var endereco = "email@email.com";
            var email = new Email(endereco);

            Assert.AreEqual(endereco, email.Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void New_Email_Invalido()
        {
            var email = new Email("laiufiaiffui");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void New_Email_Erro_MaxLength()
        {
            var endereco = "email@email.com";

            while (endereco.Length <= Email.EnderecoMaxLength)
            {
                endereco = "email" + endereco;
            }

            new Email(endereco);
        }

    }
}

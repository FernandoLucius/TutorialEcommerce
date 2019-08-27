using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TutorialEcommerce.Domain.ValueObject;

namespace TutorialEcommerce.Domain.Tests.ValueObject
{
    [TestClass]
    public class CpfTests
    {
        [TestMethod]
        public void Cpf_Valido()
        {
            var cpf = new Cpf("564.629.048-10");

            Assert.AreEqual(56462904810, cpf.Codigo);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cpf_Invalido()
        {
            var cpf = new Cpf("555.555.555-55");
        }
    }
}

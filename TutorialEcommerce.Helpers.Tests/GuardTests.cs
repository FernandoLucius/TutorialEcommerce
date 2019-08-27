using System;
using Xunit;
namespace TutorialEcommerce.Helpers.Tests
{
    public class GuardTests
    {
        [Fact]
        public void ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Assert.Throws<Exception>(() => Guard.ForNullOrEmpty("", "Valor não pode ser vazio ou null!"));
        }

        [Fact]
        public void ForNullOrEmpty_Erro_Quando_Null()
        {
            Assert.Throws<Exception>(() => Guard.ForNullOrEmpty(null, "Valor não pode ser vazio ou null!"));
        }

        [Fact]
        public void ForNegative_Quando_Menor_Que_Zero()
        {
            Assert.Throws<Exception>(() => Guard.ForNegative(-10, "NomeDaPropriedade"));
        }
    }
}

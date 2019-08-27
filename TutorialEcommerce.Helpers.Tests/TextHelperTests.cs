
using Xunit;

namespace TutorialEcommerce.Helpers.Tests
{
    public class TextHelperTests
    {
        [Fact]
        public void GetOnlyNumbers_Com_Letras_E_Numeros()
        {
            var textoLimpo = TextHelper.GetOnlyNumbers("abc123abc");

            Assert.Equal("123", textoLimpo);
        }

        [Fact]
        public void ToTitleCase_Tudo_Maiusculo()
        {
            var texto = TextHelper.ToTitleCase("GOD OF WAR");

            Assert.Equal("God Of War", texto);
        }

        [Fact]
        public void ToTitleCase_Tudo_Minusculo()
        {
            var texto = TextHelper.ToTitleCase("god of war");

            Assert.Equal("God Of War", texto);
        }

        [Fact]
        public void ToTitleCase_Aleatorio()
        {
            var texto = TextHelper.ToTitleCase("gOd oF WaR");

            Assert.Equal("God Of War", texto);
        }
    }
}

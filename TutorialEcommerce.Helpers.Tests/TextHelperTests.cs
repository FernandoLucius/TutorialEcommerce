
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
    }
}

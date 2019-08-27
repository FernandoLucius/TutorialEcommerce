using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutorialEcommerce.Helpers
{
    public class TextHelper
    {
        public static string GetOnlyNumbers(string text)
        {
            string resultString = string.Empty;
            Regex regexObj = new Regex(@"[^\d]");
            resultString = regexObj.Replace(text, "");
            return resultString;
        }

        public static string ToTitleCase(string text)
        {
            text = text.ToLower();

            TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;

            return textInfo.ToTitleCase(text); 
        }
    }
}

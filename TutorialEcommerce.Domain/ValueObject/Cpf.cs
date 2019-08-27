using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Helpers;

namespace TutorialEcommerce.Domain.ValueObject
{
    public class Cpf
    {
        public Int64 Codigo { get; set; }

        protected Cpf()
        { }

        public Cpf(string cpf)
        {
            try
            {
                cpf = CpfLimpo(cpf);
                if (!IsCpfValid(cpf))
                    throw new Exception();

                Codigo = Convert.ToInt64(cpf);
            }
            catch (Exception)
            {

                throw new Exception("CPF inválido: " + cpf);
            }
        }

        public string GetSemZeros()
        {
            return Codigo.ToString();
        }

        public string GetFullCpf()
        {
            var cpf = Codigo.ToString();

            if (String.IsNullOrEmpty(cpf))
                return "";

            while (cpf.Length < 11)
                cpf = "0" + cpf;

            return cpf;
        }

        private string CpfLimpo(string cpf)
        {
            cpf = TextHelper.GetOnlyNumbers(cpf);

            if (String.IsNullOrEmpty(cpf))
                return "";
            while (cpf.StartsWith("0"))
                cpf = cpf.Substring(1);

            return cpf;
        }

        private bool IsCpfValid(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}

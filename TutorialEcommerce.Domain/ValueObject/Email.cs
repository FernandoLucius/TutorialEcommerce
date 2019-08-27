using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Helpers;
using System.ComponentModel.DataAnnotations;

namespace TutorialEcommerce.Domain.ValueObject
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public string Endereco { get; private set; }

        //Contrutor do EntityFramework
        protected Email()
        {

        }
        public Email(string endereco)
        {
            Guard.ForNullOrEmptyDefaultMessage(endereco, "E-mail");
            Guard.StringLength("E-mail",endereco, EnderecoMaxLength);

            if (!IsValid(endereco))
                throw new Exception("E-mail inválido!");

            Endereco = endereco;
        }

        public static bool IsValid(string email) => new EmailAddressAttribute().IsValid(email);
    }
}

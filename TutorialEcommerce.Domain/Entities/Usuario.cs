using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Domain.ValueObject;

namespace TutorialEcommerce.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public Cpf Cpf { get; set; }
        public Email Email { get; set; }
        public string Login { get; set; }
        public Endereco Endereco { get; set; }
        public override bool isValid()
        {
            throw new NotImplementedException();
        }
    }
}

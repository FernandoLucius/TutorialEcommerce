using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Domain.Enuns;

namespace TutorialEcommerce.Domain.ValueObject
{
    public class Endereco
    {
        public const int LogradouroMaxLength = 150;

        public const int ComplementoMaxLength = 150;

        public const int NumeroMaxLength = 50;

        public const int BairroMaxLength = 150;

        public const int CidadeMaxLength = 150;

        public virtual string Logradouro { get; private set; }       
        public virtual string Complemento { get; private set; }
        public virtual string Numero { get; private set; }
        public virtual string Bairro { get; private set; }
        public virtual string Cidade { get; private set; }
        public virtual Uf? Uf { get; private set; }
        public virtual Cep Cep { get; private set; }

        protected Endereco() { }

        public Endereco(string logradouro, string complemento, string numero, string bairro, string cidade,
            Uf? uf, Cep cep)
        {
            SetLogradouro(logradouro);
            SetComplemento(complemento);
            SetNumero(numero);
            SetBairro(bairro);
            SetCidade(cidade);
            SetUf(uf);
            SetCep(cep);
        }

        private void SetCep(Cep cep)
        {
            throw new NotImplementedException();
        }

        private void SetUf(Uf? uf)
        {
            throw new NotImplementedException();
        }

        private void SetCidade(string cidade)
        {
            throw new NotImplementedException();
        }

        private void SetBairro(string bairro)
        {
            throw new NotImplementedException();
        }

        private void SetNumero(string numero)
        {
            throw new NotImplementedException();
        }

        private void SetComplemento(string complemento)
        {
            throw new NotImplementedException();
        }

        private void SetLogradouro(string logradouro)
        {
            throw new NotImplementedException();
        }
    }
}

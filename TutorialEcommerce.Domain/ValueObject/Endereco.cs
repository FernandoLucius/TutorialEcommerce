using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Domain.Enuns;
using TutorialEcommerce.Helpers;

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
            if (cep.Vazio())
                throw new Exception("CEP é obrigatório!");
            Cep = cep;
        }

        private void SetUf(Uf? uf)
        {
            if (!uf.HasValue)
                throw new Exception("Estado é obrigatório");
            Uf = uf;
        }

        private void SetCidade(string cidade)
        {
            Guard.ForNullOrEmptyDefaultMessage(cidade, "Cidade");
            Logradouro = TextHelper.ToTitleCase(cidade);
        }

        private void SetBairro(string bairro)
        {
            Guard.ForNullOrEmptyDefaultMessage(bairro, "Bairro");
            Logradouro = TextHelper.ToTitleCase(bairro);
        }

        private void SetNumero(string numero)
        {
            Guard.ForNullOrEmptyDefaultMessage(numero, "Número");
            Logradouro = TextHelper.ToTitleCase(numero);
        }

        private void SetComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento))
                complemento = "";
            Complemento = TextHelper.ToTitleCase(complemento);
        }

        private void SetLogradouro(string logradouro)
        {
            Guard.ForNullOrEmptyDefaultMessage(logradouro, "Endereço");
            Logradouro = TextHelper.ToTitleCase(logradouro);
        }
    }
}

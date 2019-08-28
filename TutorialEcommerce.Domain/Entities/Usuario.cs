using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Domain.ValueObject;
using TutorialEcommerce.Helpers;

namespace TutorialEcommerce.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public const int LoginMinValue = 6;
        public const int LoginMaxValue = 30;
        public const int SenhaMinValue = 6;
        public const int SenhaMaxValue = 30;

        public Cpf Cpf { get; private set; }
        public Email Email { get; private set; }
        public string Login { get; private set; }
        public Endereco Endereco { get; private set; }
        public Telefone Telefone { get; private set; }
        public byte[] Senha { get; private set; }
        public Guid TokenAlteracaoDeSenha { get; private set; }

        protected Usuario() { }

        public Usuario(string login, Cpf cpf, Email email, string senha, string confirmacaoSenha)
        {
            SetLogin(login);
            SetCpf(cpf);
            SetEmail(email);
            SetSenha(senha, confirmacaoSenha);
        }

        private void SetSenha(string senha, string confirmacaoSenha)
        {
            Guard.ForNullOrEmptyDefaultMessage(senha, "Senha");
            Guard.ForNullOrEmptyDefaultMessage(confirmacaoSenha, "Confirmação da Senha");
            Guard.StringLength("Senha", senha, SenhaMinValue, SenhaMaxValue);
            Guard.StringLength("Senha", confirmacaoSenha, SenhaMinValue, SenhaMaxValue);

            Senha = CriptografiaHelper.CriptografarSenha(senha);
        }

        private void SetEmail(Email email)
        {
            if (email == null)
                throw new Exception("E-mail é obrigatório!");

            Email = email;
        }

        private void SetCpf(Cpf cpf)
        {
            if (cpf == null)
                throw new Exception("CPF é obrigatório!");

            Cpf = cpf;
        }

        private void SetLogin(string login)
        {
            Guard.ForNullOrEmptyDefaultMessage(login, "Login");
            Guard.StringLength("Login", login, LoginMinValue, LoginMaxValue);

            // Se tiver regras de negócio para o login, colocar aqui.

            Login = login;
        }

        public override bool isValid()
        {
            throw new NotImplementedException();
        }
    }
}

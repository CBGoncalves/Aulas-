using System;
using Microsoft.Extensions.Primitives;

namespace MVCRoleTop.Models {
    public class Cliente {

        public string Nome { get; set; }
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente () {

        }

        public Cliente (string nome, string email, string senha, string endereco, string telefone, DateTime dataNascimento) {
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;

        }

    }
}
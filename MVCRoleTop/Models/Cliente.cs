using System;

namespace RoleTopOficial.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string Usuario {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataDeNascimento {get;set;}

        public Cliente(){

        }
        public Cliente( string nome, string usuario, string senha, string email, DateTime datadenascimento)
        {

            this.Nome = nome;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Email = email;
            this.DataDeNascimento = datadenascimento;
        
        }
    }
}
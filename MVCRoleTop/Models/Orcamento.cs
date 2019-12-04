using System;
using Microsoft.Extensions.Primitives;

namespace MVCRoleTop.Models
{
    public class Orcamento
    {
        public string Nome {get;set;}
        public string Telefone {get;set;}
        public string Email {get;set;}
        public DateTime DataEvento {get;set;}
        public string Evento {get;set;}
        public double NumPessoas {get;set;}
        public string ComoConheceu {get;set;}
        public string Observacoes {get;set;}

        public Orcamento (string nome, string email, string telefone, DateTime dataEvento, string evento, double numPessoas, string comoConheceu, string observacoes)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.DataEvento = dataEvento;
            this.Evento = evento;
            this.NumPessoas = numPessoas;
            this.ComoConheceu = comoConheceu;
            this.Observacoes = observacoes;
        }
    }
}
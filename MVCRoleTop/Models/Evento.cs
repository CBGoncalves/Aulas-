using System;
using RoleTopOficial.Enums;

namespace RoleTopOficial.Models
{
    public class Evento
    {
        public ulong ID {get;set;}
        public string Nome {get;set;}
        public string DonoDoEvento {get;set;}
        public DateTime DataDoEvento {get;set;}
        public string TipoDeEvento {get;set;}
        public int NumeroDePessoas {get;set;}

        public uint Status {get;set;}

        public Evento(){
            
        }
        public Evento(string nome, DateTime datadoevento, string tipodeevento,int numerodepessoas )
        {

            this.ID = 0;
            this.Status = (uint) StatusPedidos.PENDENTE;
            this.DonoDoEvento = "";
            this.Nome = nome;
            this.DataDoEvento = datadoevento;
            this.TipoDeEvento = tipodeevento;
            this.NumeroDePessoas = numerodepessoas;

        }

    }
}
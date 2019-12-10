using System.Collections.Generic;
using RoleTopOficial.ViewModel;
using RoleTopOficial.Models;

namespace RoleTopOficial.ViewModel
{
    public class ClienteViewModel : BaseViewModel
    {
        public string Usuario {get;set;}
        public List<Evento> Eventos {get;set;}

        public ClienteViewModel( string usuario )
        {
            this.Eventos = new List<Evento>();
            this.Usuario = usuario;
        }
    }
}
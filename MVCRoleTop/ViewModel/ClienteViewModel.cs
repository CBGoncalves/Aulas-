using System.Collections.Generic;
using MVCRoleTop.ViewModel;
using MVCRoleTop.Models;

namespace MVCRoleTop.ViewModel
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
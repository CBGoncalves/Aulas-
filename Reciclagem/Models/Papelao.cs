using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class Papelao : Lixo, IPapel
    {
        public bool LixoPapel()
        {
            System.Console.WriteLine("Lixeira: Papel | Cor: Azul");
            return true;
        }
    }
}
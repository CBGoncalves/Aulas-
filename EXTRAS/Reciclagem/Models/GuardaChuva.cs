using System;
using Reciclagem.Interfaces;

namespace Reciclagem.Models
{
    public class GuardaChuva : Lixo, IMetais
    {
        public bool LixoMetal()
        {
            System.Console.WriteLine("Lixeira: Metal | Cor: Amarelo");
            return true;
        }
    }
}
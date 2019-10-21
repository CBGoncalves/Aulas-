using System;
using ByteBank2.Model;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente1 = "Alexandre";
            string cliente2 = "Cesar";

            #region Testa Conta Corrente
            ContaCorrente contaCorrente = new ContaCorrente (1, 1, cliente1);
            ContaEspecial contaEspecial = new ContaEspecial (1, 2, cliente2);
            contaCorrente.Deposito(10);
            #endregion
        }
    }
}

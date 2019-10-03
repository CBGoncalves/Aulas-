namespace ByteBank.Models
{
    public class ContaCorrente
    {
        public string Titular {get; set;}
        public string Agencia {get; set;}
        public int Numero {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente(string Agencia, int Numero, string Titular){
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }
    }
}
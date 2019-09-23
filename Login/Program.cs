using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;

            Console.WriteLine("Insira E-mail ou Usuario");
            login = Console.ReadLine();

            Console.WriteLine("Insira sua senha");
            password = Console.ReadLine();

            if((login == "admin")  && (password == "admin"))
                Console.WriteLine("Bem Vindo ADM");
                else{
                    Console.WriteLine("Bem Vindo Usuario");
                }

          


            
        }
    }
}

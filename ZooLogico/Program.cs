using System;

namespace ZooLogico
{
    enum AnimaisEnum : uint
    {
        ARARA


    }
    class Program
    {
        static void Main(string[] args)
        {
            do {
                string menuBar = "=================================";
                string func;

                System.Console.WriteLine(menuBar);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("       ZOOLÓGICO        ");
                System.Console.WriteLine("     Seja bem vindo     ");
                Console.ResetColor();
                System.Console.WriteLine(menuBar);

                ExibirMenuDeAnimais();


                System.Console.WriteLine("|(1) Para ir Novamente|(0) Para sair");
                func = Console.ReadLine();

            }while(func == "1");
        }

        public static void ExibirMenuDeAnimais()
        {
            var animais = Enum.GetNames(typeof(AnimaisEnum));
            int codigo = 1;
            string menuAnimaisBorda = "###########################";

            System.Console.WriteLine(menuAnimaisBorda);
            System.Console.WriteLine("#                       #");
            System.Console.WriteLine("#        ANIMAIS        #");
            System.Console.WriteLine("#                       #");
            System.Console.WriteLine(menuAnimaisBorda);

            foreach (var animal in animais)
            {
                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(animal)}");
            }

            System.Console.WriteLine(menuAnimaisBorda);

        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }

    }
}

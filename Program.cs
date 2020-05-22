using System;

namespace MilhasParaKm

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Olá usuário, digite um valor em milhas para receber o seu valor equivalente em quilômetros.");

            int milhas = Int32.Parse (Console.ReadLine ());



            int quilometros = 1609;

            int resultadodamultiplicacao = milhas * quilometros; 



            Console.WriteLine (resultadodamultiplicacao + " km");



            Console.ReadKey();

        }

    }

}
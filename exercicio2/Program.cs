using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float Celcius = 0;
            bool flag = false;

            Console.WriteLine("Insira uma temperatura em Celcius: ");

            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out Celcius);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            var Fahrenheit = (9 * Celcius + 160) / 5;

            Console.WriteLine("Esta temperatura em Fahrenheit fica " + Fahrenheit);
        }
    }
}
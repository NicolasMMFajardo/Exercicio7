using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float Fahrenheit = 0;
            bool flag = false;

            Console.WriteLine("Insira uma temperatura em Fahreinheit: ");

            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out Fahrenheit);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            var Celcius = (Fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Esta temperatura em Celcius fica " + Celcius);
        }
    }
}
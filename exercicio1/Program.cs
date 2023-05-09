using System;

namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            float USD = 0;
            float valorUSD = 0;
            
            Console.WriteLine("Insira a cotação do dolar: ");

            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out USD);    
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);
                  
            Console.WriteLine("Insira um valor em dolares: ");

            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out valorUSD);    
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            var valorReal = valorUSD * USD;
            Console.WriteLine(valorUSD + " dolares equivale a " + valorReal + " reais");
        }
    }
}
using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            float Salario = 0;
            bool flag = false;

            Console.WriteLine("Entre com o salário para reajuste: ");

            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out Salario);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            if (Salario < 1850)
                Salario += 320;
            else
                Salario += 180;

            Console.WriteLine("O salário com reajuste fica " + Salario);
        }
    }
}
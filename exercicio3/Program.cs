using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso = 0, altura = 0;
            bool flag = false;

            Console.WriteLine("Qual seu peso em quilos: ");
            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out peso);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);
            
            Console.WriteLine("Qual sua altura em metros: ");
            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out altura);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            var imc = peso/(altura*altura);

            Console.WriteLine("Seu imc é de " + imc);

            if (imc <= 18.5){
                Console.WriteLine("Você se encaixa na classificação abaixo do peso");
            } else if(imc < 25){
                Console.WriteLine("Você se encaixa na classificação de peso ideal");
            } else if (imc < 30){
                Console.WriteLine("Você se encaixa na classificação levemente acima do peso");
            } else if (imc < 35){   
                Console.WriteLine("Você se encaixa na classificação obesidade grau 1");
            } else if (imc < 40){   
                Console.WriteLine("Você se encaixa na classificação obesidade grau 2");
            } else {
                Console.WriteLine("Você se encaixa na classificação obesidade grau 3");
            }

        }
    }
}
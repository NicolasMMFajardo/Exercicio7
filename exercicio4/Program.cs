using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float tempo = 0, velocidade = 0;
            bool flag = false;

            Console.WriteLine("Quanto tempo em minutos foi gasto na viagem?");
            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out tempo);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);
            
            Console.WriteLine("Qual foi a velocidade média em km/h?");
            do{
                var input = Console.ReadLine();
                if (input is not null){
                    flag = float.TryParse(input.Replace(".",","), out velocidade);
                    if (!flag){
                        Console.WriteLine("Formato invalido, insira apenas numeros.");
                    }
                }
            } while(!flag);

            var distancia = (tempo/60)*velocidade;
            var litrosUsados = distancia/12;

            Console.WriteLine("Tempo de viagem: " + tempo + " minutos");
            Console.WriteLine("Velocidade média: " + velocidade + " km/h");
            Console.WriteLine("Distancia percorrida: " + distancia + " km");
            Console.WriteLine("Litros de combustivel usados: " + litrosUsados);

        }
    }
}
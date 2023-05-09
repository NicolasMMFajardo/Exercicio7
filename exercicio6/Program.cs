using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vet = {};
            int i = 0;

            Console.WriteLine("Entre com uma frase:");
            var frase = Console.ReadLine();
            if (frase is not null){
                vet = frase.ToCharArray();
                foreach (char c in frase){
                    if (c == 'a' || c == 'A'){
                        vet[i] = '&';
                    }
                    i++;
                }
            }
            
            frase = new string(vet);
            Console.WriteLine(frase);
        }
    }
}
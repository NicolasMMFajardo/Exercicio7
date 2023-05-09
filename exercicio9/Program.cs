using System;
using System.IO;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:/Users/pablo/OneDrive/Área de Trabalho/Nicolas/ProgramaçãoAllog/exercicio9/arquivo.txt";
            string nome = "";
            string email = "";
            string telefone = "";
            string RG = "";

            Console.WriteLine("Entre com o seu nome: ");
            var input = Console.ReadLine();
            if(input is not null)
                nome = input;

            Console.WriteLine("Entre com o seu email: ");
            input = Console.ReadLine();
            if(input is not null)
                email = input;

            Console.WriteLine("Entre com o seu telefone: ");
            input = Console.ReadLine();
            if(input is not null)
                telefone = input;
            
            Console.WriteLine("Entre com o seu RG: ");
            input = Console.ReadLine();
            if(input is not null)
                RG = input;

            try{
                StreamWriter arquivo = new StreamWriter(filePath);
                arquivo.WriteLine(("nome: " + nome));
                arquivo.WriteLine(("e-mail: " + email));
                arquivo.WriteLine(("telefone: " + telefone));
                arquivo.WriteLine(("RG: " + RG));
                arquivo.Close();

            } catch(Exception ex){
                Console.WriteLine("Exceção:" + ex.Message);
            }
            
            try{
                Console.WriteLine("\n");
                StreamReader arquivo = new StreamReader(filePath);
                var linha = arquivo.ReadLine();
                while (linha is not null){
                    Console.WriteLine(linha);
                    linha = arquivo.ReadLine();
                }
                arquivo.Close();
            }catch(Exception ex){
                Console.WriteLine("Exceção:" + ex.Message);
            }
        }
    }
}
using System;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int acao;
            string filePath = "C:/Users/pablo/OneDrive/Área de Trabalho/Nicolas/ProgramaçãoAllog/exercicio10/IMC.txt";

            do{
                Console.Clear();
                acao = menu();
                switch(acao){
                    case 1:
                        cadastrar();
                    break;
                    case 2:
                        consultar();
                    break;
                }
            } while(acao != 3);

            void consultar(){
                Console.Clear();
                try{
                    Console.WriteLine("\n");
                    StreamReader arquivo = new StreamReader(filePath);
                    var linha = arquivo.ReadLine();
                    while (linha is not null){
                        Console.WriteLine(linha);
                        linha = arquivo.ReadLine();
                    }
                    arquivo.Close();
                    Console.ReadLine();
                }catch(Exception ex){
                    Console.WriteLine("Exceção:" + ex.Message);
                }
            }

            void cadastrar(){
                bool flag = false;
                float peso = 0, altura = 0;
                int idade = 0;

                Console.Clear();

                Console.WriteLine("Digite seu nome para registro: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Qual sua idade?");
                do{
                    var input = Console.ReadLine();
                    if (input is not null){
                        flag = int.TryParse(input, out idade);
                        if (!flag){
                            Console.WriteLine("Formato invalido, insira apenas numeros.");
                        }
                    }
                } while(!flag);

                Console.WriteLine("Qual seu peso em quilos? ");
                do{
                    var input = Console.ReadLine();
                    if (input is not null){
                        flag = float.TryParse(input.Replace(".",","), out peso);
                        if (!flag){
                            Console.WriteLine("Formato invalido, insira apenas numeros.");
                        }
                    }
                } while(!flag);
            
                Console.WriteLine("Qual sua altura em metros? ");
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
                try{
                    StreamWriter arquivo = new StreamWriter(filePath, true);
                    arquivo.WriteLine("Nome: " + nome + ", Idade: " + idade + ", Peso: " + peso + ", Altura: " + altura + ", IMC: " + imc);
                    arquivo.Close();

                } catch(Exception ex){
                    Console.WriteLine("Exceção:" + ex.Message);
                }
            }

            int menu(){
                int acao = 1;
                bool flag = false;
            
                Console.WriteLine("----- CALCULADORA IMC ----");
                Console.WriteLine("Digite 1 caso queira realizar um novo cadastro;");
                Console.WriteLine("Digite 2 caso queira consultar os cadastros existentes;");
                Console.WriteLine("Digite 3 caso queira encerrar o programa;");
                do{
                    var input = Console.ReadLine();
                    if (input is not null){
                        flag = int.TryParse(input, out acao);
                        if (!flag || (acao != 1 && acao != 2 && acao != 3)){
                            if (!flag){
                                Console.WriteLine("Formato invalido, insira apenas numeros.");
                            } else {
                                Console.WriteLine("Ação invalida, tente novamente.");
                                flag = false;
                            }
                        }
                    }
                } while(!flag);
                return acao;
            }
        }
    }
}
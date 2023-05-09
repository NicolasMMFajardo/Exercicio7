namespace exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Nicolas";
            
            if (nome is not null){
                Console.WriteLine(olaNome(nome));
            }
            
            Console.WriteLine(olaNome("João"));

            string olaNome(string nome){
                return ("Olá meu nome é: " + nome);
            }
        }
    }
}
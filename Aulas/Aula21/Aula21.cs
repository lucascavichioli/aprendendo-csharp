//loop do while
using System; 


class Aula21 {

    static void Main(){

        int i = 2;

        do{
            
            Console.WriteLine("Executei pelo menos uma vez. Valor: {0}", i);
            i++;

        }while(i < 3);

        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhauser = Console.ReadLine();
            tentativas++;
        }while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha correta, tentativas: {0}", tentativas);

    }

}
using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;
            string question1, response1;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            Console.Write("Are you more intelligent than me?");
            question1 = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Gran'pa";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            switch (question1)
            {
                default:
                    response1 =  "Obviously!";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);

            Console.WriteLine(response1);
        }
    }
}

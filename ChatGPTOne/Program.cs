using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
             // Variáveis auxiliares
            string question, response;
        

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

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
                case "What's your favourite tea?":
                    response = "coffee is better than tea!";
                    break;
                case "EXIT":
                    return;
                default:
                    response = "I don't recognize that question";
                    break;
            }

           
            // Responder adequadamente
            Console.WriteLine(response);

            
        }
    }
}

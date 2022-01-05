using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();                                 //Criação de um objeto do tipo Elevador

            int cont = 0;                                                       // Inicia uma variável de controle
                
            
            // Informações iniciais do projeto
            Console.WriteLine("PROJETO ELEVADOR");
            Console.WriteLine("");
            Console.WriteLine("CONFIGURAÇÕES INICIAIS");
            
            Console.WriteLine("O elevador possui quantos andares?");            // Pede para o usuário definir o total de andares
            int andares = int.Parse(Console.ReadLine());                        // Armazena o total de andares na variável andares
            Console.WriteLine("Qual a capacidade máxima de pessoas?");          // Pede para o usuário definir a capacidade máxima
            int capacidade = int.Parse(Console.ReadLine());                     // Armazena a capacidade máxima na variável capacidade

            while (cont == 0)                                                   // Loop de controle do elevador
            {
                // Instruções sobre o funcionamento do elevador
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Digite o número para escolher uma das opções abaixo.");
                Console.WriteLine("");
                Console.WriteLine("Inicializar - 1");
                Console.WriteLine("");
                Console.WriteLine("Entrar - 2");
                Console.WriteLine("Sair - 3");
                Console.WriteLine("Subir - 4");
                Console.WriteLine("Descer - 5");
                Console.WriteLine("");
                Console.WriteLine("Redefinir configurações do elevador - 6");
                Console.WriteLine("Fechar Programa - 7");
                Console.WriteLine("");
                int opcao = int.Parse(Console.ReadLine());                      // Armazena a escolha no usuário na variavel opcao

                switch (opcao)                                                  // Tratamento das opções escolhidas pelo usuário
                {
                    case 1:
                        elevador.Inicializar(andares, capacidade);              // Chama o método Inicializar e envia os andares e a capacidade escolhida pelo usuário
                        break;
                    case 2:
                        elevador.Entrar();                                      // Chama o método Entrar
                        break;  
                    case 3:
                        elevador.Sair();                                        // Chama o método Entrar
                        break;
                    case 4:
                        elevador.Subir();                                       // Chama o método Entrar
                        break;
                    case 5:
                        elevador.Descer();                                      // Chama o método Entrar
                        break;
                    case 6:                                                     // Recebe as novas configurações do elevador 
                        Console.WriteLine("O elevador possui quantos andares?");
                        andares = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a capacidade máxima de pessoas?");
                        capacidade = int.Parse(Console.ReadLine());
                        elevador.Inicializar(andares, capacidade);              // Chama o método Inicializar passando os novos valores
                        break;
                    case 7:
                        cont = 1;                                               // Muda o contador para 1 e encerra o loop
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção válida selecionada!"); // Notifica o usuário caso nenhum dos valores válidos seja digitado
                        break;
                }

            }

            Console.WriteLine("Programa encerrado!");                           //Notifica o usuário que o programa terminou






        }
    }
}

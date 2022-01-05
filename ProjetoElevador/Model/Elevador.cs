using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {
        
        //Declaração das variáveis do projeto
        int andarAtual;
        int totalAndares;
        int capElevador;
        int qtdPessoas;


        public void Inicializar(int andares, int capacidade) //Método para definir a quantidade de andares e a capacidade máxima.
        {
            totalAndares = andares;                     //Variável totalAndares recebe por parâmentro o número de andares 
            capElevador = capacidade;                   //Variável capElevador recebe por parâmentro o máximo de pessoas
            qtdPessoas = 0;                             //O elevador inicia com nenhuma pessoa  
            andarAtual = 0;                             //O elevador inicia no térreo 
            Console.WriteLine("Elevador Iniciado!");    //Messagem para notificar o usuário que o elevador foi iniciado
        }

        public void Entrar()                            //Método para adicionar pessoas ao elevador
        {
            if (qtdPessoas < capElevador)               //Compara o valor atual com a capacidade máxima
            {
                qtdPessoas++;                           //Adiciona uma pessoa se o elevador não estiver cheio
                Console.WriteLine("Total de pessoas no elevador: " + qtdPessoas);   //Exibi a quantidade de pessoas
            }
            else
            {
                Console.WriteLine("O elevador está em sua capacidade máxima! Por favor, aguarde o próximo.");   //Notifica o usuário que o elevador está cheio
            }
        }

        public void Sair()                              //Método para retirar pessoas do elevador
        {
            if (qtdPessoas > 0)                         //Verifica se o elevador não está vazio
            {
                qtdPessoas--;                           //Retira uma pessoa caso o elevador não esteja vazio
                Console.WriteLine("Total de pessoas no elevador: " + qtdPessoas);   //Exibi a quantidade de pessoas
            }
            else
            {
                Console.WriteLine("O elevador está vazio!");        //Notifica o usuário que o elevador está vazio
            }
        }

        public void Subir()                                         //Método para subir de andar
        {
            if (andarAtual < totalAndares)                          //Compara o andar atual com o total de andares
            {
                andarAtual++;                                       //Sobe um andar se o elevador não estiver no último
                Console.WriteLine("Andar atual: " + andarAtual);    //Exibi o andar atual
            }
            else
            {
                Console.WriteLine("O elevador já está no último andar. Por favor, escolha uma andar abaixo."); //Notifica o usuário que o elevador chegou no último andar
            }
        }

        public void Descer()                                        //Método para descer de andar
        {
            if (andarAtual > 0)                                     //Verifica se o elevador não está no térreo 
            {
                andarAtual--;                                       //Desce um andar
                Console.WriteLine("Andar atual: " + andarAtual);    //Exibi o andar atual
            }
            else
            {
                Console.WriteLine("O elevador já está no térreo. Por favor, escolha uma andar acima.");     //Notifica o usuário que o elevador está no térreo.
            }
        }


    }
}

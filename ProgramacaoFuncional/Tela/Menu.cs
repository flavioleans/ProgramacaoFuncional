using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        //DECLARANDO AS CONSTANTES DO PROJETO
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVO = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIO = 5;
        public const int CADASTRAR_FORNECEDOR = 6;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa." +
                "\n Digite uma das opções abaixo:" +
                "\n0 - Sair do Programa" +
                "\n1 - Para Ler um arquivo" +
                "\n2 - Para Executar a tabuada" +
                "\n3 - Para calcular a media do aluno" +
                "\n4 - Para cadastrar clientes" +
                "\n5 - Para cadastrar usuario" +
                "\n6 - Para cadastrar fornecedor";

                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == SAIDA_PROGRAMA)
                {
                    return;
                }
                else if (opcao == LER_ARQUIVO)
                {
                    Console.Clear();
                    Arquivo.LerArquivoPorNumero(1);
                }
                else if (opcao == TABUADA)
                {
                    Console.Clear();
                    Console.WriteLine("Informe o numero da tabuada:");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                }
                else if (opcao == CALCULO_MEDIA)
                {
                    Console.Clear();
                    Media.Aluno();

                }
                else if (opcao == CADASTRAR_CLIENTES)
                {
                    Console.Clear();
                    TelaCliente.Chamar();
                }
                else if (opcao == CADASTRAR_USUARIO)
                {
                    Console.Clear();
                    TelaUsuario.Chamar();
                }
                else if (opcao == CADASTRAR_FORNECEDOR)
                {
                    Console.Clear();
                    TelaFornecedor.Chamar();
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }


        }
    }
}

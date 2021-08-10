using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("================Cadastro de Cliente==================");
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa." +
               "\n Digite uma das opções abaixo:" +
               "\n0 - Sair do Programa" +
               "\n1 - Para Cadastrar Clientes" +
               "\n2 - Para Listar Clientes";

                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {

                    var cliente = new Cliente();
                    Console.WriteLine("================Cadastro de Cliente==================");

                    Console.WriteLine("Digite o nome do cliente:");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone:");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o nome do CPF:");
                    cliente.Cpf = Console.ReadLine();
                    cliente.Gravar();

                    Console.Clear();
                    Console.WriteLine("Cliente cadastrado com sucesso");
                    Console.WriteLine("Deseja repetir a operação? 1=Sim / 2=Não");
                    int resp = int.Parse(Console.ReadLine());
                    if (resp == 1)
                    {
                        Chamar();
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    var clientes = new Cliente().Ler();
                    Console.WriteLine("================Lista de Cliente==================");

                    foreach (Base c in new Cliente().Ler())
                    {
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF" + c.Cpf);
                        Console.WriteLine("----------------------------------------------");

                    }
                    Console.WriteLine("Total de Clientes na lista: " + clientes.Count);
                }

            }

        }

    }
}

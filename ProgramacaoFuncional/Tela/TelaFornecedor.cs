using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("================Cadastro de Fornecedor==================");
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa." +
               "\n Digite uma das opções abaixo:" +
               "\n0 - Sair do Programa" +
               "\n1 - Para Cadastrar Fornecedor" +
               "\n2 - Para Listar Fornecedor";

                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {

                    var fornecedor = new Fornecedor();
                    Console.WriteLine("================Cadastro de Fornecedor==================");

                    Console.WriteLine("Digite o CNPJ do fornecedor:");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o nome do fornecedor:");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone:");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o nome do CPF do Gerente:");
                    fornecedor.Cpf = Console.ReadLine();
                    fornecedor.Gravar();

                    Console.Clear();
                    Console.WriteLine("Fornecedor cadastrado com sucesso");
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
                    var fornecedores = new Fornecedor().Ler();
                    Console.WriteLine("================Lista de Fornecedor==================");

                    foreach (Fornecedor c in new Fornecedor().Ler())
                    {
                        Console.WriteLine("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF do Gerente" + c.Cpf);
                        Console.WriteLine("----------------------------------------------");
                    }
                    Console.WriteLine("Total de Fornecedors na lista: " + fornecedores.Count);
                    Console.WriteLine("----------------------------------------------");
                }

            }

        }

    }
}

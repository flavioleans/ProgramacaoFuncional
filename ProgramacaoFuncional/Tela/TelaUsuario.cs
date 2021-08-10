using Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("================Cadastro de Usuario==================");
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa." +
               "\n Digite uma das opções abaixo:" +
               "\n0 - Sair do Programa" +
               "\n1 - Para Cadastrar Usuario" +
               "\n2 - Para Listar Usuario";

                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {

                    var usuario = new Usuario();
                    Console.WriteLine("================Cadastro de Usuario==================");

                    Console.WriteLine("Digite o nome do usuario:");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone:");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o nome do CPF:");
                    usuario.Cpf = Console.ReadLine();
                    usuario.Gravar();

                    Console.Clear();
                    Console.WriteLine("Usuario cadastrado com sucesso");
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
                    var usuarios = new Usuario().Ler();
                    Console.WriteLine("================Lista de Usuario==================");

                    foreach (Base c in new Usuario().Ler())
                    {
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF" + c.Cpf);
                        Console.WriteLine("----------------------------------------------");

                    }
                    Console.WriteLine("Total de Usuarios na lista: " + usuarios.Count);
                }

            }

        }

    }
}

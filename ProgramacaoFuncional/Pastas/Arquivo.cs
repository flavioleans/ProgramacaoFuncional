using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio

{
    class Arquivo

    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_Arquivo"];
        }
        public static void LerArquivoPorNumero(int numeroArquivo)
        {
            string caminhoDoArquivo = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            //verifica se o arquivo existe
            if (File.Exists(caminhoDoArquivo))
            {
                using (StreamReader arquivo = File.OpenText(caminhoDoArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {

                        Console.WriteLine(linha);
                        
                    }
                    Console.WriteLine("***************************");
                }
            }

            //USANDO A RECURSIVDADE DENTRO DO MESMO MÉTODO
            //cria caminho do novo arquivo acrescentando mais 1
            string caminhoArquivo2 = caminhoArquivo() + "arq" + (numeroArquivo + 1) + ".txt";
            //verifica se existe
            if (File.Exists(caminhoArquivo2))
            {
                LerArquivoPorNumero(numeroArquivo + 1);
            }

        }
    }
}

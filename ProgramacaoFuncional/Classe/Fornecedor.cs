using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public Fornecedor(string _nome, string _telefone, string _Cpf, string _cnpj)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _Cpf;
            this.CNPJ = _cnpj;
        }

        public Fornecedor()
        {

        }

        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            StreamWriter r = new StreamWriter(diretorioComArquivo());
            //cabeçalho
            r.WriteLine("nome;telefone;cpf;cnpj;");

            foreach (Fornecedor b in dados)
            {
                var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";" + b.CNPJ + ";";
                r.WriteLine(linha);
            }

            r.Close();
        }

        public override List<IPessoa> Ler()
        {

            var dados = new List<IPessoa>();

            //verifica se o arquivo existe
            if (File.Exists(diretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioComArquivo()))
                {
                    string linha;
                    //ignorando primeira linha
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseAquivo = linha.Split(';');

                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseAquivo[0]);
                        b.SetTelefone(baseAquivo[1]);
                        b.SetCpf(baseAquivo[2]);
                        b.CNPJ = (baseAquivo[3]);
                        //var b = new Base(baseAquivo[0], baseAquivo[1], baseAquivo[2]);

                        dados.Add(b);

                    }

                }
            }

            return dados;
        }


    }
}


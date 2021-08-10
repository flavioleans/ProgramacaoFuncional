using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
   public abstract class Base : IPessoa
    {
        public Base(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
        }

        public Base()
        {

        }

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCpf(string cpf) { this.Cpf = cpf; }

        public string Nome;
        public string Telefone;
        public string Cpf;


        public virtual void Gravar()
        {

            var dados = this.Ler();
            dados.Add(this);
           
                StreamWriter r = new StreamWriter(diretorioComArquivo());
                //cabeçalho
                r.WriteLine("nome;telefone;cpf");

                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";";
                    r.WriteLine(linha);
                }

                r.Close();
        }

        public virtual List<IPessoa> Ler()
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

                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseAquivo[0]);
                        b.SetTelefone(baseAquivo[1]);
                        b.SetCpf(baseAquivo[2]);
                        //var b = new Base(baseAquivo[0], baseAquivo[1], baseAquivo[2]);

                        dados.Add(b);

                    }

                }
            }

            return dados;
        }

        public  string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }


    }
}

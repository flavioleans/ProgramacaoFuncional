using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Usuario : Base
    {
        public Usuario(string _nome, string _telefone, string _Cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _Cpf;
        }

        public Usuario()
        {

        }


    }
}


using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class Cliente : Base
    {
        public Cliente()
        {

        }
        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
        }
        //public string Nome;
        //public string Telefone;
        //public string Cpf;

        //metodo protected
        //só pode ser usado dentro da classe, não pode ser instanciado fora.
        //metodo private -> tem acesso na instancia da classe.
 
    
       


    }
}

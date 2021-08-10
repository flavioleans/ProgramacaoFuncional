
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este metodo só pode ser acessado dentro deste assembly componentes";
        }

        public string MetodoParaTodosutilizarAssembly()
        { 
            
            return "Este metodo é para todos";
        }
    }
}

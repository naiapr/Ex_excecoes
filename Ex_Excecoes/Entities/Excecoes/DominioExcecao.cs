using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Excecoes.Entities.Excecoes
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string message) : base(message)
        {
        }
    
    }
}

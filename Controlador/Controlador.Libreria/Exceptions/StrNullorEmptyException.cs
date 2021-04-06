using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Libreria.Exceptions
{
    public class StrNullorEmptyException : Exception
    {
        public StrNullorEmptyException()
        {

        }        
        public StrNullorEmptyException(string message): base (message)
        {
            
        }       
    }
}

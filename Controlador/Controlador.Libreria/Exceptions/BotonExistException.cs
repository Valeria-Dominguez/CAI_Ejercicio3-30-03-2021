using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Libreria.Exceptions
{
    public class BotonExistException : Exception
    {
        public BotonExistException() : base ("El código de botón no existe")
        {

        }
        public BotonExistException(string message) : base(message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Libreria.Entidades
{
    public class Boton
    {
        uint _codigo;
        string _descripcion;

        internal uint Codigo { get => _codigo; }
        internal string Descripcion { get => _descripcion; }

        public Boton (uint codigo, string descripcion)
        {
            _codigo = codigo;
            _descripcion = descripcion;
        }
    }
}

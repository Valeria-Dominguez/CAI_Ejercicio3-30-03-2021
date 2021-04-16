using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Libreria.Exceptions;
using Controlador.Libreria.Validaciones;


namespace Controlador.Libreria.Entidades
{
    public class Controlador
    {
        int _codigoControlador;
        List<Boton>_botones;
       
        public Controlador(int codigoContr)
        {
            _codigoControlador = codigoContr;
            this._botones = new List<Boton>();
        }
       
        public string AgregarBoton() 
        {
            uint codigo = PedirCodigoBoton();

            Boton BotonDevuelto = BuscarCodigoTraerBoton(codigo);
            if (BotonDevuelto == null)
            {
                string descripcion = "";
                descripcion = Validaciones.Validaciones.ValidarStrNoVac("Ingrese descripción\n");

                Boton nuevoboton = new Boton(codigo, descripcion);
                this._botones.Add(nuevoboton);
                return "El botón fue agregado con éxito\n";
            }
            else 
            {
                throw new BotonExistException("El botón ingresado ya existe\n");
            }
        }

        public string ListarBotones() 
        {
            string retorno = "";
            foreach (Boton boton in this._botones)
            {
                retorno = retorno + boton.Codigo + "\n";
            }
            if (retorno =="")
            {
                retorno = "No hay botones ingresados\n";
            }
            return retorno;
        }

        public string EliminarBoton()
        {
            string retorno = "";
            uint codigo = PedirCodigoBoton();

            Boton BotonDevuelto = BuscarCodigoTraerBoton(codigo);
            if (BotonDevuelto == null)
            {
                retorno = "El botón no existe\n";
            }
            else
            {
                this._botones.Remove(BotonDevuelto);
               retorno = "El botón fue eliminado con éxito\n";
            }
            return retorno;
        }

        public string MostrarDescripcion()
        {
            string retorno = "";
            uint codigo = PedirCodigoBoton();

            Boton BotonDevuelto = BuscarCodigoTraerBoton(codigo);
            if (BotonDevuelto==null)
            {
                retorno = "El codigo ingresado no existe\n";
            }
            else
            {
                retorno = (BotonDevuelto.Descripcion + "\n");
            }
            return retorno;
        }

        Boton BuscarCodigoTraerBoton(uint codigo)
        {
            Boton valor = null;

            foreach (Boton boton in this._botones)
            {
                if (boton.Codigo == codigo)
                {
                    valor = boton;
                }
            }
            return valor ;
        }

        uint PedirCodigoBoton ()
        {
            uint valor = 0;
            valor = Validaciones.Validaciones.ValidarUint("Ingrese código del botón");
            return valor;
        }
    }
}

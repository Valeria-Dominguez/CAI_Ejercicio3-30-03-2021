using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Libreria.Exceptions;

namespace Controlador.Libreria.Entidades
{
    public class Controlador
    {
        int _codigoContr;
        List<Boton>_botones;
        public int CodigoContr
        {
            get
            {
                return _codigoContr;
            }
            set
            {
                _codigoContr = value;
            }
        }            
        public List<Boton> Botones
        {
            get
            {
                return _botones;
            }
            set
            {
                _botones = value;
            }
        }
        public Controlador(int codigoContr)
        {
            CodigoContr = codigoContr;
            Botones = new List<Boton>();
        }
       
        public void AgregarBoton()
        {
            uint cod = 0;
            string descrip = "";

            Console.WriteLine("Ingrese código del botón");
            if (!uint.TryParse(Console.ReadLine(), out cod))
            {
                throw new NoUIntException("Debe ingresar un entero entre 0 y 4.294.967.295\n");                     
            }

            foreach (Boton b in Botones)
            {
                if (b.Codigo == cod)
                {
                    throw new BotonExistException("El botón ingresado ya existe");
                }
            }

            Console.WriteLine("Ingrese descripción");
            descrip = Console.ReadLine();
            if (descrip == "")
            {
                throw new StrNullorEmptyException("El campo no puede estar vacío");
            }

            Boton btn = new Boton(cod, descrip);
            Botones.Add(btn);
            Console.WriteLine("El botón fue agregado con éxito\n");
        }
        public void ListarBotones()
        {
            foreach (Boton b in Botones)
            {
                Console.WriteLine(b.Codigo);
            }            
        }
        public void EliminarBoton()
        {
            uint cod = 0;
            Console.WriteLine("Ingrese código del botón");
            if (!uint.TryParse(Console.ReadLine(), out cod))
            {
                throw new NoUIntException("Debe ingresar un entero entre 0 y 4.294.967.295\n");
            }
            foreach (Boton b in Botones)
            {
                if (b.Codigo == cod)
                {
                    Botones.Remove(b);
                    Console.WriteLine("El botón fue eliminado con éxito\n");
                }
            }
        }
        public void MostrarDescripcion()
        {
            uint cod = 0;
            Console.WriteLine("Ingrese código del botón");
            if (!uint.TryParse(Console.ReadLine(), out cod))
            {
                throw new NoUIntException("Debe ingresar un entero entre 0 y 4.294.967.295\n");
            }
            foreach (Boton b in Botones)
            {
                if (b.Codigo == cod)
                {
                    Console.WriteLine(b.Descripcion + "\n");
                }
            }
        }
    }
}

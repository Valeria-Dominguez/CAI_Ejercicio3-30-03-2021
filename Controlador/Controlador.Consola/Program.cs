using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Libreria.Entidades;
using Controlador.Libreria.Exceptions;
using Controlador.Libreria.Validaciones;

namespace Controlador.Consola
{
    class Program
    {
        static Controlador.Libreria.Entidades.Controlador MiControlador;
        static void Main(string[] args)
        {
            MiControlador = new Controlador.Libreria.Entidades.Controlador(1);
            MenuPcipal();

            void MenuPcipal()
            {
                string opcion = "";
                const string opAgregarBoton = "1";
                const string opListarBotones = "2";
                const string opEliminarBoton = "3";
                const string opMostrarDespcripcion = "4";
                const string opSalir = "5";
                do
                {
                    opcion = Validaciones.ValidarStrNoVac("Ingrese una opción:\n" +
                        opAgregarBoton + ".Agregar Botón\n" +
                        opListarBotones + ".Listar Botones\n" +
                        opEliminarBoton + ".Eliminar Boton\n" +
                        opMostrarDespcripcion + ".Mostrar Descripción\n" +
                        opSalir + ".Salir\n");

                    switch (opcion)
                    {
                        case opAgregarBoton:
                            try
                            {
                                Console.WriteLine(MiControlador.AgregarBoton());
                            }
                            catch (BotonExistException BtnExistexe)
                            {
                                Console.WriteLine(BtnExistexe.Message);
                            }
                            break;
                        case opListarBotones:
                            Console.WriteLine(MiControlador.ListarBotones());
                            break;
                        case opEliminarBoton:
                            Console.WriteLine(MiControlador.EliminarBoton());
                            break;
                        case opMostrarDespcripcion:
                            Console.WriteLine(MiControlador.MostrarDescripcion());
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
                while (opcion != opSalir);
            }           

        }
    }
}

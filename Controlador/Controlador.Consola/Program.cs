using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador.Libreria.Entidades;
using Controlador.Libreria.Exceptions;

namespace Controlador.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador.Libreria.Entidades.Controlador MiControlador = new Controlador.Libreria.Entidades.Controlador(1);

            string opcion = "";
            const string opAgregarBoton = "1";
            const string opListarBotones = "2";
            const string opEliminarBoton = "3";
            const string opMostrarDespcripcion = "4";
            const string opSalir = "5";
            do
            {
                Console.WriteLine("Ingrese una opción:\n" +
                    opAgregarBoton + ".Agregar Botón\n" +
                    opListarBotones + ".Listar Botones\n" +
                    opEliminarBoton + ".Eliminar Boton\n" +
                    opMostrarDespcripcion + ".Mostrar Descripción\n" +
                    opSalir + ".Salir\n");

                opcion = Console.ReadLine().ToUpper();

                try
                {
                    if (opcion == "")
                    {
                        throw new StrNullorEmptyException("El campo no puede estar vacío");
                    }
                    switch (opcion)
                    {
                        case opAgregarBoton:
                            try
                            {
                                MiControlador.AgregarBoton();
                            }
                            catch (NoUIntException NoUIntexe)
                            {
                                Console.WriteLine(NoUIntexe.Message);
                            }
                            catch (BotonExistException BtnExistexe)
                            {
                                Console.WriteLine(BtnExistexe.Message);
                            }
                            catch (StrNullorEmptyException StrNOEexe)
                            {
                                Console.WriteLine(StrNOEexe.Message);
                            }
                            break;
                        case opListarBotones:
                            MiControlador.ListarBotones();
                            break;
                        case opEliminarBoton:
                            try
                            {
                                MiControlador.EliminarBoton();
                            }
                            catch (NoUIntException NoUIntexe)
                            {
                                Console.WriteLine(NoUIntexe.Message);
                            }
                            break;
                        case opMostrarDespcripcion:
                            try
                            {
                                MiControlador.MostrarDescripcion();
                            }
                            catch (NoUIntException NoUIntexe)
                            {
                                Console.WriteLine(NoUIntexe.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }
                catch (StrNullorEmptyException Exe)
                {
                    Console.WriteLine(Exe.Message);
                }
            }
            while (opcion != opSalir);           
        }
    }
}

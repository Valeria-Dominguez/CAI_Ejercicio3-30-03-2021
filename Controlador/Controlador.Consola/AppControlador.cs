using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.Consola
{
    class AppControlador
    {
        const string _opListarBotones = "1";
        const string _opAgregarBoton = "2";
        const string _opEliminarBoton = "3";
        const string _opMostrarDespcripcion = "4";
        const string _opSalir = "5";
        public void MenuPcipal()
        {
            string opcion = "";
            do
            {
                do
                {
                    Console.WriteLine("Ingrese una opción:\n" +
                    _opListarBotones + ".Listar Botones\n" +
                    _opAgregarBoton + ".Agregar Botón\n" +
                    _opEliminarBoton + ".Eliminar Boton\n" +
                    _opMostrarDespcripcion + ".Mostrar Descripción\n" +
                    _opSalir + ".Salir\n");

                    opcion = Console.ReadLine().ToUpper();
                    if (opcion != _opListarBotones && opcion != _opAgregarBoton && opcion != _opEliminarBoton && opcion != _opMostrarDespcripcion && opcion != _opSalir)
                    {
                        Console.WriteLine("Debe ingresar una opción válida");
                    }

                }
                while (opcion != _opListarBotones && opcion != _opAgregarBoton && opcion != _opEliminarBoton && opcion != _opMostrarDespcripcion && opcion != _opSalir);                           

                switch (opcion)
                {
                    case _opListarBotones:
                        ListarBotones();
                        break;
                    case _opAgregarBoton:
                        AgregarBoton();
                        break;
                    case _opEliminarBoton:
                        EliminarBoton();
                        break;
                    case _opMostrarDespcripcion:
                        MostrarDescripcion();
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            while (opcion != _opSalir);
        }

        public void ListarBotones()
        {
            ;
        }
        public void AgregarBoton()
        {
            ;
        }
        public void EliminarBoton()
        {
            ;
        }
        public void MostrarDescripcion()
        {
            ;
        }

    }
}

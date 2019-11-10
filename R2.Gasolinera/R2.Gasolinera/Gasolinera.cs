using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2.Gasolinera
{
    //Herencia
    class Gasolinera : RepoGasolinera
    {
        //Es para dar la bienvenida
        public void Principal()
        {

            Console.WriteLine("¡Bienvenido a la mejor gasolinera!");
            Console.WriteLine("");

            Menu();
        }
        //Menu para llamar a los metodos, utilizando el switch
        private void Menu()
        {
            //Opciones de tarea
            Console.WriteLine("Ingrese el numero de opcion que desea:");
            Console.WriteLine("1.Crear Empleado\n2.-Lista empleados \n3.-Listar Area de trabajo \n4.- Lista de empleado y area \n5.-Detalles empleado\n\n6.-Salir");
            switch (Console.ReadLine())
            {
                case "1":
                    //Agregar empleado
                    Console.WriteLine("Agregar empleado:");
                    AgregarEmpleado();
                    break;

                case "2":
                    //Llamamos al metodo de Crear taras
                    Console.WriteLine("Lista de empleados:");
                    ListaEmpleados();
                    break;
                case "3":
                    //Se realiza el metodo de listar tareas
                    Console.WriteLine("Lista de Areas de trabajo");
                    ListaArea();
                    break;

                case "4":
                    //Se muestran los detalles que contiene la tarea en general
                    Console.WriteLine("Lista de Empleados y Area:");
                    ListaEA();
                    break;

                case "5":
                    //Muestra el status de las tareas 
                    Console.WriteLine("Detalles de Empleado:");
                    DetallesEmpleado();
                    break;

                

                case "6":
                    //Se da salida al programa
                    Console.WriteLine("bye bye");
                    Environment.Exit(0);
                    break;

                default:
                    //Si se ingresa alguna opcion que no es la edecuada 
                    Console.WriteLine("No es valido");
                    break;
            }
            Console.Clear();
            Menu();
        }
    }
}

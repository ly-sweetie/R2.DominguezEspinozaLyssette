using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2.Gasolinera
{
    class RepoGasolinera:Data

    {
        //Se instancia dato para hacer la lista de tareas
        List<Empleado> lista = new List<Empleado>();

        public List<Empleado> Empleados()

        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado { Nombre = "Chanyeol", Area = "Caja", Email = "yeol91@live.com" });
            empleados.Add(new Empleado { Nombre = "Mordecai", Area = "Almacen", Email = "mordo1@gmail.com" });
            empleados.Add(new Empleado { Nombre = "Baekhyun", Area = "Limpieza", Email = "baekz3@hotmail.com" });
            empleados.Add(new Empleado { Nombre = "Alexis", Area = "Administracion", Email = "onlyalexx@live.com" });

           

        }
        //Ver la lista de empleados que se tiene
        public void ListaEmpleados()
        {
            foreach (Empleado x in lista)
            {
                Console.WriteLine(x.Nombre);
                Console.WriteLine("♡");
                Console.ReadKey();

                
            }

        }

        public void ListaArea()
        {
            foreach (Empleado x in lista)
            {
                Console.WriteLine(x.Area);
                Console.WriteLine("♡");
                Console.ReadKey();

            }
        }

        //Ver el area de cada empleado
        public void ListaEA()
        {
            foreach (Empleado x in lista)
            {
                Console.WriteLine(x.Nombre+":"+x.Area);
                Console.WriteLine(" ");
                Console.ReadKey();

            }
        }
        // Metodo para visualizar los detallas del empleado
        public void DetallesEmpleado()
        {
            //Utilizamos foreach para que se "recorrer" los elementos que utilizamos
            foreach (Empleado e in lista)
            {
                Console.WriteLine("Detalles:\n Nombre:"+e.Nombre+ "\nArea:"+ e.Area+"\nEmail:"+e.Email);
                Console.WriteLine(" ");
                Console.ReadKey();

            }
        }

        public void AgregarEmpleado()
        {
            //Instanciar tarea
            Empleado Emp = new Empleado();
            //Ingreso de datos en los atributos
            Console.WriteLine("Ingrese Nombre:");
            Emp.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Area:");
            Emp.Area = Console.ReadLine();
            Console.WriteLine("Ingresar Email:");
            Emp.Email = Console.ReadLine();
            

            lista.Add(Emp);

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaContacto
{

    class Program
    {
       private static List<string> Contactos = new List<string>();
            enum opciones
             { 
             Agregar = 1,
             Editar,
             Listar,
             Eliminar

             }
        
        static void Main(string[] args)
        {
            Menu();
        }
        static private void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("ingresa una de las opciones \n 1-Agregar \n 2-Editar \n 3-Listar \n 4-Eliminar");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case (int)opciones.Agregar:
                        Agregar();
                        break;
                    case (int)opciones.Editar:
                        Editar();
                        break;
                    case (int)opciones.Listar:
                        Listar(true);
                        break;
                    case (int)opciones.Eliminar:
                        Eliminar();
                        break;
                    default:
                        Console.WriteLine("ingresa una Opcion valida");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ingresa una Opcion valida");
                Console.ReadKey();
                Menu();

                throw;
                
            }
       
        }
        static private void Agregar()
        {
            Console.Clear();
            int contador = 1;
            foreach (string item in Contactos)
            {
                contador++;
            }
            if (contador >15) 
            {
                Console.WriteLine("Acaba de llegar al maximo de contacto que son 15, volvera al menu principal");
                Console.ReadKey();
                Menu();
            }
            Console.WriteLine("Ingresa un contacto");
            string contacto = Console.ReadLine();

            Contactos.Add(contacto);
            


            Console.WriteLine("Su contacto fue agregado");
            Console.ReadKey();

            Menu();
        }



        static private void Editar()         
        {
            Console.Clear();
            Listar();

            try
            {
                
                Console.WriteLine("Selecciones el contacto que quiere editar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el nuevo contacto");
                string Nuevocontacto = Console.ReadLine();

                Contactos[opcion - 1] = Nuevocontacto;
                Console.WriteLine("El contacto fue editado");
                Menu();

            }
            catch (Exception)
            {
                Console.WriteLine("ingresa una Opcion valida");
                Console.ReadKey();
                Editar();

                throw;

            }


        }



        static private void Listar(bool ismenu = false) 
        {
            Console.Clear();
            int contador = 1;
            foreach (string item in Contactos)
            {

                Console.WriteLine(contador + " - " + item );
                contador++;
            }
            

            if (ismenu) 
            {
                Console.ReadKey();
                Menu();
            }
        }
        static private void Eliminar()
        {
            Console.Clear();
            Listar();

            try
            {

                Console.WriteLine("Selecciones el contacto que quiere eliminar");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Contactos.RemoveAt(opcion - 1);
                Console.WriteLine("El contacto fue eliminado ");
                Menu();

            }
            catch (Exception)
            {
                Console.WriteLine("ingresa una Opcion valida");
                Console.ReadKey();
                Eliminar();

                throw;

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.Negocio;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {

            string clave = Console.ReadLine();
            Console.WriteLine(clave);
            clave = Utilidades.Encriptar(clave);
            Console.WriteLine(clave);
            Console.WriteLine(clave.Length);

            Console.Read();

            


            //Especialidad esp = new Especialidad(/*1, "MEDICINA GENERAL"*/);

            //if (esp.Create())
            //{
            //    Console.WriteLine("Se agregó");


            //    if (esp.Read(1))
            //    {
            //        Console.WriteLine("id {0} y el nombre es {1}", esp.Id, esp.Nombre);
            //    }
            //}else
            //{
            //    Console.WriteLine("None");
            //}
            //Console.WriteLine("Inserte id de la especialidad");
            //int id = int.Parse(Console.ReadLine());
            //if (esp.Read(id))
            //{
                
            //    Console.WriteLine("id {0} y el nombre es {1}", esp.Id, esp.Nombre);
            //}else
            //{
            //    Console.WriteLine("Algun tipo de Excepcion");
            //    // hay que manejar las execciones qui para informar bien al web service =)
            //}

            //Console.Read();
        }
    }
}

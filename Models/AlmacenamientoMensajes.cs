using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Estatico.Models
{
    public class AlmacenamientoMensajes
    {
        public static List<string> Mensajes { get; set; }

        public static void AgregarMensajes(){
            Console.WriteLine("Escribe el mensaje que deseas agregar: ");
            var mensaje = Console.ReadLine();
            Mensajes.Add(mensaje);
        }

        public static void MostrarMensajes(){
            foreach(var mensaje in Mensajes){
                Console.WriteLine(mensaje);
            }
        }
    }
}
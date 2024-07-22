using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Estatico.Models
{
    public class Configuracion
    {
        public static bool ModoOscuro { get; set; } = false;

        public static void CambiarModo(){
            ModoOscuro = true;
            Console.WriteLine($"El valor de ModoOscuro es {ModoOscuro}");
        }
    }
}
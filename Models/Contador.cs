using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Estatico.Models
{
    public class Contador
    {
        public static int TotalContadores { get; set; }

        public static void Incrementar(){
            Console.WriteLine($"El contadoe esta en: {TotalContadores++}");
        }
    }
}
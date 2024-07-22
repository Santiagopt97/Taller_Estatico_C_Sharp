using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Estatico.Models
{
    public class Convertidor
    {
        public static double CelsiusAFahrnheit(double celsius){
            return (celsius * 9/5) + 32;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Estatico.Models
{
    public class CalculadoraAritmetica
    {
        public static double Sumar(double a, double b){
            return a + b;
        }
        public static double Restar(double a, double b){
            return a - b;
        }

        public static double Multiplicar(double a, double b){
            return a * b;
        }
        public static double Dividir(double a, double b){
            return a / b;
        }
    }
}
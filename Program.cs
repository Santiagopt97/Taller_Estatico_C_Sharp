using Taller_Estatico.Models;
//Punto 1
Contador.Incrementar();
Contador.Incrementar();

//Punto 2
Console.WriteLine("Ingresa los grados en celsius");
var celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{celsius} celsius en fahrenheit son: {Convertidor.CelsiusAFahrnheit(celsius)}"); 

// Punto 3
Configuracion.CambiarModo();

// Punto 4

Console.WriteLine("Ingresa un número");
var num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa otro número");
var num2 = Convert.ToDouble(Console.ReadLine());

var calculadora = new MatematicaUtil();

Console.WriteLine($"La Suma de {num1} + {num2} es igual a: {calculadora.Sumar(num1, num2)}");
Console.WriteLine($"La Resta de {num1} - {num2} es igual a: {calculadora.Restar(num1, num2)}");
Console.WriteLine($"La Multiplicacion de {num1} * {num2} es igual a: {calculadora.Multiplicar(num1, num2)}");
Console.WriteLine($"La Division de {num1} / {num2} es igual a: {calculadora.Dividir(num1, num2)}");

// Punto 5

Console.WriteLine("Ingresa un número");
var num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa otro número");
var num4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"La Suma de {num3} + {num4} es igual a: {CalculadoraAritmetica.Sumar(num3, num4)}");
Console.WriteLine($"La Resta de {num3} - {num4} es igual a: {CalculadoraAritmetica.Restar(num3, num4)}");
Console.WriteLine($"La Multiplicacion de {num3} * {num4} es igual a: {CalculadoraAritmetica.Multiplicar(num3, num4)}");
Console.WriteLine($"La Division de {num3} / {num4} es igual a: {CalculadoraAritmetica.Dividir(num3, num4)}");

// Punto 6
AlmacenamientoMensajes.AgregarMensajes();


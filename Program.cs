//EJERCICIO NÚMERO 01
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Aplicación para escribir tu nombre y dar la hora actual");
Console.Write("Ingresa tu nombre: ");
String name = Console.ReadLine();
Console.WriteLine("Hola " +  name);

//EJERCICIO NÚMERO 02
DateTime Hora = DateTime.Now;
Console.WriteLine("La hora es " + Hora.ToString("HH:mm:ss"));
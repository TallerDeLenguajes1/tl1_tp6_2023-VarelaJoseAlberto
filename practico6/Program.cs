// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");
//Ejercicios propuestos para entrar en contacto con el lenguaje

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);
*/
// Ejercicio 1
// Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el texto ingresado es de hecho un número y, 
// en caso afirmativo, realice la inversión del número sólo si éste es mayor a 0.

// int num, invertido = 0;
// bool control = false;
// string? numString;

// while (!control)
// {
//     Console.WriteLine("ingrese el numero a invertir");
//     numString = Console.ReadLine();
//     control = int.TryParse(numString, out num);
//     if (!control)
//     {
//         Console.WriteLine(numString + " no es un numero valido");
//     }
//     else
//     {
//         if (num > 0)
//         {
//             invertido = 0;
//             while (num > 0)
//             {
//                 invertido = (invertido * 10) + (num % 10);
//                 num /= 10;
//             }
//             Console.WriteLine("el numero invertido es: " + invertido);
//             break;
//         }
//         else
//         {
//             Console.WriteLine("el numero ingresado es negativo o cero");
//         }
//     }
// }

using System;

Console.WriteLine("Ingrese una cadena de texto:");
string cadena = Console.ReadLine();

// Obtener la longitud de la cadena
int longitud = cadena.Length;
Console.WriteLine("Longitud de la cadena: " + longitud);

Console.WriteLine("Ingrese otra cadena de texto:");
string otraCadena = Console.ReadLine();

// Concatenar ambas cadenas distintas
string concatenacion = cadena + otraCadena;
Console.WriteLine("Concatenación de las cadenas: " + concatenacion);

// Extraer una subcadena de la cadena ingresada
Console.WriteLine("Ingrese el índice inicial para extraer la subcadena:");
int indiceInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());

string subcadena = cadena.Substring(indiceInicial, longitudSubcadena);
Console.WriteLine("Subcadena extraída: " + subcadena);

// Realizar operaciones utilizando la calculadora
Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
double num2 = double.Parse(Console.ReadLine());

double suma = num1 + num2;
double resta = num1 - num2;
double multiplicacion = num1 * num2;
double division = num1 / num2;

Console.WriteLine("La suma de " + num1 + " y " + num2 + " es igual a: " + suma);
Console.WriteLine("La resta de " + num1 + " y " + num2 + " es igual a: " + resta);
Console.WriteLine("La multiplicación de " + num1 + " y " + num2 + " es igual a: " + multiplicacion);
Console.WriteLine("La división de " + num1 + " y " + num2 + " es igual a: " + division);

// Recorrer la cadena de texto con un ciclo foreach
Console.WriteLine("Recorriendo la cadena de texto:");
foreach (char caracter in cadena)
{
    Console.WriteLine(caracter);
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese la palabra a buscar:");
string palabraBuscar = Console.ReadLine();

if (cadena.Contains(palabraBuscar))
{
    Console.WriteLine("La palabra '" + palabraBuscar + "' se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra '" + palabraBuscar + "' no se encuentra en la cadena.");
}

// Convertir la cadena a mayúsculas y luego a minúsculas
string cadenaMayusculas = cadena.ToUpper();
string cadenaMinusculas = cadena.ToLower();

Console.WriteLine("Cadena en mayúsculas: " + cadenaMayusculas);
Console.WriteLine("Cadena en minúsculas: " + cadenaMinusculas);

// Ingresar una cadena separada por caracteres y mostrar los resultados
Console.WriteLine("Ingrese una cadena separada por caracteres:");
string cadenaSeparada = Console.ReadLine();

string[] elementos = cadenaSeparada.Split(' ');

Console.WriteLine("Elementos separados:");
foreach (string elemento in elementos)
{
    Console.WriteLine(elemento);
}

// Resolver una ecuación simple ingresada como cadena de caracteres
Console.WriteLine("Ingrese una ecuación simple:");
string ecuacion = Console.ReadLine();

string[] partes = ecuacion.Split('+');

double num3 = double.Parse(partes[0]);
double num4 = double.Parse(partes[1]);
double resultado = num3 + num4;

Console.WriteLine("El resultado de la ecuación es: " + resultado);

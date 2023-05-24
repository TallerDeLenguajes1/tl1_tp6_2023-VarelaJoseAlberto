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
/* 
Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el texto ingresado es de hecho un número y, 
en caso afirmativo, realice la inversión del número sólo si éste es mayor a 0.

int num, invertido = 0;
bool control = false;
string? numString;

while (!control)
{
    Console.WriteLine("ingrese el numero a invertir");
    numString = Console.ReadLine();
    control = int.TryParse(numString, out num);
    if (!control)
    {
        Console.WriteLine(numString + " no es un numero valido");
    }
    else
    {
        if (num > 0)
        {
            invertido = 0;
            while (num > 0)
            {
                invertido = (invertido * 10) + (num % 10);
                num /= 10;
            }
            Console.WriteLine("el numero invertido es: " + invertido);
            break;
        }
        else
        {
            Console.WriteLine("el numero ingresado es negativo o cero");
        }
    }
}
*/
/*
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una calculadora que permita al usuario realizar 
las 4 operaciones básicas (Sumar, Restar, Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y 
que luego pida dos números y que devuelva el resultado de la operación seleccionada. Además una vez que termine de realizar 
la operación le pregunte si desea realizar otro cálculo.
*/
// Declaracion de variables
int opcion, num1, num2, resultado;
string? numString;
bool continuar = true, control1 = true, control2 = true;
while (continuar)
{
    // Menú
    do
    {
        Console.WriteLine("Elija una opción: \n1 - Sumar \n2 - Restar \n3 - Multiplicar \n4 - Dividir \n0 - Salir");
        numString = Console.ReadLine();
        continuar = int.TryParse(numString, out opcion);
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Eligio la opcion 1 de Sumar 2 numeros enteros");
                break;
            case 2:
                Console.WriteLine("Eligio la opcion 2 de Restar 2 numeros enteros");
                break;
            case 3:
                Console.WriteLine("Eligio la opcion 3 de Multiplicar 2 numeros enteros");
                break;
            case 4:
                Console.WriteLine("Eligio la opcion 4 de Dividir 2 numeros enteros");
                break;
            case 0:
                Console.WriteLine("Eligio la opcion 0 de Salir");
                break;
            default:
                Console.WriteLine("Opcion Invalida\n");
                break;
        }
    } while (opcion < 0 || opcion > 4);


    Console.WriteLine("ingrese el primer numero:");
    numString = Console.ReadLine();
    control1 = int.TryParse(numString, out num1);
    Console.WriteLine("ingrese el segundo numero:");
    numString = Console.ReadLine();
    control2 = int.TryParse(numString, out num2);
    if (control1 && control2)
    {
        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("el resultado es: " + resultado);
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine("el resultado es: " + resultado);
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine("el resultado es: " + resultado);
                break;
            case 4:
                resultado = num1 / num2;
                Console.WriteLine("el resultado de la division entera es: " + resultado);
                break;
        }
    }
    else
    {
        Console.WriteLine("uno o los dos numeros ingresados no son numeros enteros");
    }
    Console.WriteLine("Desea Realizar otra Operacion? - Presione 0 para salir o 1 para relizar otra operacion");
    numString = Console.ReadLine();
    continuar = int.TryParse(numString, out opcion);
    if (opcion == 0)
    {
        continuar = false;
    }
}
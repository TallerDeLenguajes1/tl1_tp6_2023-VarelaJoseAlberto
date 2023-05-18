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
Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una
calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar,
Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego
pida dos números y que devuelva el resultado de la operación seleccionada. Además
una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.
*/
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
// Declaracion de variables
int opcion, num1, num2, resultado;
double num3, num4, resultado2;
string? numString;
bool continuar = true, control1 = true, control2 = true;
while (continuar)
{
    // Menú
    do
    {
        Console.WriteLine("Elija una opción: \n1 - Sumar \n2 - Restar \n3 - Multiplicar \n4 - Dividir");
        Console.WriteLine("5 - Valor Absoluto de un numero \n6 - El Cuadrado \n7 - La Raiz Cuadrada \n8 - El Seno \n9 - El Coseno \n10 - Parte entera de un dato tipo float");
        Console.WriteLine("11 - El Maximo entre dos numeros \n12 - El Minimo entre dos numeros \n0 - Salir");
        numString = Console.ReadLine();
        continuar = int.TryParse(numString, out opcion);

    } while (opcion < 0 || opcion > 12);
    if (opcion == 0)
    {
        Console.WriteLine("Eligio la opcion numero '0' de Salir");
        continuar = false;
        Console.WriteLine("Has elegido Salir");
    }
    else
    {
        if (opcion < 4 && opcion > 0)
        {
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
                        Console.WriteLine("Eligio la opcion numero '1' de Sumar 2 numeros enteros");
                        resultado = num1 + num2;
                        Console.WriteLine("el resultado es: " + resultado);
                        break;
                    case 2:
                        Console.WriteLine("Eligio la opcion numero '2' de Restar 2 numeros enteros");
                        resultado = num1 - num2;
                        Console.WriteLine("el resultado es: " + resultado);
                        break;
                    case 3:
                        Console.WriteLine("Eligio la opcion numero '3' de Multiplicar 2 numeros enteros");
                        resultado = num1 * num2;
                        Console.WriteLine("el resultado es: " + resultado);
                        break;
                    case 4:
                        Console.WriteLine("Eligio la opcion numero '4' de Dividir 2 numeros enteros");
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir por cero");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("el resultado es: " + resultado);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Eligio la opcion numero '5' de Valor Absoluto de un numero");
                        resultado = Math.Abs(num1);
                        Console.WriteLine("el resultado es: " + resultado);
                        break;
                }

            }
            else
            {
                Console.WriteLine("uno o los dos numeros ingresados no son numeros enteros");
            }
        }
        else if (opcion == 5)
        {
            Console.WriteLine("ingrese un numero:");
            numString = Console.ReadLine();
            control1 = int.TryParse(numString, out num1);
            if (control1)
            {
                Console.WriteLine("Eligio la opcion numero '5' de Valor Absoluto de un numero");
                resultado = Math.Abs(num1);
                Console.WriteLine("el resultado es: " + resultado);
            }
        }
        else if (opcion < 11 && opcion > 5)
        {
            Console.WriteLine("ingrese un numero:");
            numString = Console.ReadLine();
            control1 = double.TryParse(numString, out num3);

            if (control1)
            {
                switch (opcion)
                {
                    case 6:
                        Console.WriteLine("Eligio la opcion numero '6' de El Cuadrado de un numero");
                        resultado2 = Math.Pow(num3, 2);
                        Console.WriteLine("el resultado es: " + resultado2);
                        break;
                    case 7:
                        Console.WriteLine("Eligio la opcion numero '7' de La Raiz Cuadrada de un numero");
                        resultado2 = Math.Sqrt(num3);
                        Console.WriteLine("el resultado es: " + resultado2);
                        break;
                    case 8:
                        Console.WriteLine("Eligio la opcion numero '8' de El Seno de un numero");
                        resultado2 = Math.Sin(num3);
                        Console.WriteLine("el resultado es: " + resultado2);
                        break;
                    case 9:
                        Console.WriteLine("Eligio la opcion numero '9' de El Coseno de un numero");
                        resultado2 = Math.Cos(num3);
                        Console.WriteLine("el resultado es: " + resultado2);
                        break;
                    case 10:
                        Console.WriteLine("Eligio la opcion numero '10' de Parte entera de un numero");
                        int parteEntera = (int)Math.Floor(num3);
                        Console.WriteLine("Parte entera: " + parteEntera);
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("ingrese un numero:");
            numString = Console.ReadLine();
            control1 = double.TryParse(numString, out num3);
            Console.WriteLine("ingrese otro numero:");
            numString = Console.ReadLine();
            control2 = double.TryParse(numString, out num4);

            if (control1 && control2)
            {
                switch (opcion)
                {
                    case 11:
                        Console.WriteLine("Eligio la opcion numero '11' de El Maximo entre 2 numeros");
                        resultado2 = Math.Max(num3, num4);
                        Console.WriteLine("El maximo entre " + num3 + " y " + num4 + " es: " + resultado2);
                        break;
                    case 12:
                        Console.WriteLine("Eligio la opcion numero '12' de El Minimo entre 2 numeros");
                        resultado2 = Math.Min(num3, num4);
                        Console.WriteLine("El minimo entre " + num3 + " y " + num4 + " es: " + resultado2);
                        break;
                }
            }
            else
            {
                Console.WriteLine("uno o los dos numeros ingresados no son numeros enteros");
            }
        }
        Console.WriteLine("Desea Realizar otra Operacion? - Presione 0 para salir o 1 para relizar otra operacion");
        numString = Console.ReadLine();
        continuar = int.TryParse(numString, out opcion);
        if (opcion == 0)
        {
            continuar = false;
        }
        Console.Clear();
    }
}
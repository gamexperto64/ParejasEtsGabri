using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("Calculadora básica");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Operacion("sumar");
                break;
            case 2:
                Operacion("restar");
                break;
            case 3:
                Operacion("multiplicar");
                break;
            case 4:
                Operacion("dividir");
                break;
            case 5:
                Console.WriteLine("¡Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                Menu();
                break;
        }
    }

    static void Operacion(string operacion)
    {
        Console.Write("Ingrese el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resultado = 0;

        switch (operacion)
        {
            case "sumar":
                resultado = Sumar(a, b);
                break;
            case "restar":
                resultado = Restar(a, b);
                break;
            case "multiplicar":
                resultado = Multiplicar(a, b);
                break;
            case "dividir":
                resultado = Dividir(a, b);
                break;
        }

        Console.WriteLine($"El resultado de {operacion} {a} y {b} es: {resultado}");
        Console.WriteLine();
        Menu();
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int Restar(int a, int b)
    {
        return a - b;
    }

    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("¡Error! No se puede dividir por cero.");
            return 0;
        }
        else
        {
            return a / b;
        }
    }
}


/*Cambio para probar*/
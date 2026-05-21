using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 ==================================="); //Contador de caracteres
        Console.WriteLine();
        Console.WriteLine("Palabra: Raton ");
        Console.WriteLine("Palabra: Insomnio");
        Console.WriteLine();
        Console.WriteLine("Número de caracteres en cada palabra: ");
        Console.WriteLine();
        ContarCaracteres("Raton");
        ContarCaracteres("Insomnio");
        Console.ReadLine();
        Console.Clear();


        //EJERCICIO 2
        int A = 13;
        int B = 4;

        Console.WriteLine("EJERCICIO 2 ==================================="); // Intercambio de valores
        Console.WriteLine();

        Console.WriteLine("ANTES: ");
        Console.WriteLine();
        Console.WriteLine("A = " + A + " y B = " + B);

        Intercambio(ref A, ref B);

        Console.WriteLine("DESPUES: ");
        Console.WriteLine();
        Console.WriteLine("A = " + A + " y B = " + B);

        Console.ReadLine();
        Console.Clear();


        //EJERCICIO 3
        double precioBoleto = 45.50;
        double descuento = 0.15;

        Console.WriteLine("EJERCICIO 3 ==================================="); // Cálculo de descuento
        Console.WriteLine();

        Console.WriteLine("Precio original del boleto: " + precioBoleto);
        Console.WriteLine();

        CalcularDescuento(descuento, ref precioBoleto);

        Console.WriteLine("Precio del boleto con descuento: " + precioBoleto);

        Console.ReadLine();
        Console.Clear();



        //EJERCICIO 4
        Console.WriteLine("EJERCICIO 4 ==================================="); // Simulación de salud de un personaje
        Console.WriteLine();

        Console.WriteLine("Ingrese puntos de salud: (0-20)"); //Para obtener distintas calificaciones, se pueden ingresar valores entre 0 y 20 como puntos de salud.
        int puntosSalud = int.Parse(Console.ReadLine());

        mostrarSalud(puntosSalud);

        Console.WriteLine("El personaje recibe daño...");
        recibirDaño(ref puntosSalud);
        Console.WriteLine();
        mostrarSalud(puntosSalud);

        Console.WriteLine("El personaje se cura...");
        curar(ref puntosSalud);
        Console.WriteLine();
        mostrarSalud(puntosSalud);

        calificarDesempeño(puntosSalud);



    }
    static void ContarCaracteres(string a)
    {
        Console.WriteLine(a.Length);

    }

    static void Intercambio(ref int a, ref int b)
    {
        int cambio = a;

        a = b;
        b = cambio;
    }

    static void CalcularDescuento(double descuento ,ref double precio)
    {
        double montoDescuento = precio * descuento;
        precio = precio - montoDescuento;
    }

    static void recibirDaño(ref int puntosSalud)
    {
        puntosSalud = puntosSalud - 5;

        if (puntosSalud < 0)
        {
            puntosSalud = 0;
        }
    }

    static void curar(ref int puntosSalud)
    {
        puntosSalud += 3;

        if (puntosSalud > 15 )
        {
            puntosSalud = 15;
        }
    }

    static void mostrarSalud(int puntosSalud)
    {
        if (puntosSalud >= 11)
        {
            Console.ForegroundColor = ConsoleColor.Green;

        }
        else if (puntosSalud >= 6)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        } 

        Console.WriteLine("Puntos de salud actual: " + puntosSalud);
        Console.ResetColor();
    }

    static void calificarDesempeño(int puntosSalud)
    {
        Console.WriteLine("CALIFICACIÓN: ");
        Console.WriteLine();

        if (puntosSalud == 15)
        {
            Console.WriteLine("S");
            Console.WriteLine("GRANDIOSO!");
        }
        else if (puntosSalud >= 11)
        {
            Console.WriteLine("A");
            Console.WriteLine("Buen trabajo!");
        }
        else if (puntosSalud >= 6)
        {
            Console.WriteLine("B");
            Console.WriteLine("Puedes mejorar!");
        }
        else if (puntosSalud >= 1)
        {
            Console.WriteLine("C");
            Console.WriteLine("Desempeño deficiente");
        }
    }
}
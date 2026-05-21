using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 ===============================================");
        Console.WriteLine();

        Console.Write("Ingrese un numero entero: ");
        int num = int.Parse(Console.ReadLine());

        int mayor = num;
        int menor = num;
        int suma = num;

        for (int i = 1; i < 20; i++)
        {
            Console.Write("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            suma += num;

            if (num > mayor)
            {
                mayor = num;
            }
            else if (num < menor)
            {
                menor = num;
            }
        }
        Console.WriteLine();

        double promedio = (double)suma / 20;

        Console.WriteLine("Numero mayor: " + mayor);
        Console.WriteLine("Numero menor: " + menor);
        Console.WriteLine("El promedio es: " + promedio);

        Console.ReadLine();
        Console.Clear();


        // EJERCICIO 2
        Console.WriteLine("EJERCICIO 2 ===============================================");
        Console.WriteLine();

        int numero = 1;

        for (int i = 0; i < 100; i++)
        {
            if (numero % 2 == 0 && numero % 7 == 0)
            {
                Console.Write("ParSiete");
                Console.WriteLine();
            }
            else if (numero % 2 == 0)
            {
                Console.Write("Par");
                Console.WriteLine();
            }
            else if (numero % 7 == 0)
            {
                Console.Write("Siete");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(numero);
            }
            numero++;
        }
        Console.ReadLine();
        Console.Clear();


        //EJERCICIO 3
        Console.WriteLine("EJERCICIO 3 ===============================================");
        Console.WriteLine();
        int cliente = 10;
        double monto;
        double dinero = 0;
        int clientesConDescuento = 0;

        do
        {
            cliente--;

            Console.Write("Ingrese el monto de la compra: ");
            string compra = Console.ReadLine();
            monto = double.Parse(compra);
            Console.WriteLine();

            if (monto > 0 && monto <= 300)
            {
                Console.WriteLine();
                Console.WriteLine("Su total a pagar es de: Q" + monto); //No se aplica descuento
                Console.WriteLine();
                dinero += monto;
            }

            else if (monto > 300 && monto <= 700)
            {
                Console.WriteLine();
                Console.WriteLine("Descuento del 5% aplicado. Total a pagar: Q" + (monto * 0.95));
                Console.WriteLine();
                dinero += monto;
                clientesConDescuento++;
            }
            else if (monto > 700)
            {
                Console.WriteLine();
                Console.WriteLine("Descuento del 12% aplicado. Total a pagar: Q" + (monto * 0.88));
                Console.WriteLine();
                dinero += monto;
                clientesConDescuento++;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Monto no valido."); //No se ingreso una cantidad valida
                Console.WriteLine();
            }

        } while (cliente > 0);

        Console.WriteLine();
        Console.WriteLine("Cantidad de clientes con descuento: " + clientesConDescuento);
        Console.WriteLine("Total de ventas en el dia: Q" + dinero);

        Console.ReadLine();
        Console.Clear();

        //EJERCICIO 4
        Console.WriteLine("EJERCICIO 4 ===============================================");
        Console.WriteLine();

        Console.WriteLine("Ingrese un numero entero: ");
        int numeroE4 = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Elige una de las siguientes opciones: ");
        Console.WriteLine();
        Console.WriteLine("1. Mostrar los numeros desde el numero ingresado hasta 1.");
        Console.WriteLine("2. Mostrar los numeros multiplos de 3 hasta el numero ingresado.");
        Console.WriteLine("3. Mostrar los numeros multiplos de 5 desde hasta el numero ingresado.");
        string consoleOption = Console.ReadLine();

        switch (consoleOption)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("Numeros desde " + numeroE4 + " hasta 1:");
                for (int i = numeroE4; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
                break;

            case "2":
                Console.WriteLine();
                Console.WriteLine("Numeros multiplos de 3 hasta " + numeroE4 + ":");
                for (int i = 1; i <= numeroE4; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;

            case "3":
                Console.WriteLine();
                Console.WriteLine("Numeros multiplos de 5 hasta " + numeroE4);
                for (int i = 1; i <= numeroE4; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Opcion no valida.");
                break;
        }

        Console.ReadLine();
        Console.Clear();


        //EJERCICIO 5
        Console.WriteLine("EJERCICIO 5 ===============================================");
        Console.WriteLine();

        Console.WriteLine("Ingrese un numero: ");

        int piramide = int.Parse(Console.ReadLine());

        for (int i = 1; i <= piramide; i++)
        {
            for (int asteriscos = 1; asteriscos <= i; asteriscos++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 ===================================================");
        string nombre = "Luis Pedro Martinez Bobadilla";
        int carnet = 1081126;
        int indice = 1;
        Console.WriteLine();
        Console.WriteLine("Nombre: " + nombre + "| Carnet: " + carnet);

        Console.WriteLine();

        while (indice <= 20) //Mientras indice sea menor o igual a 20
        {
            if (indice % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write(indice + ", ");

            //Por ultimo, aumentamos el valor de indice en 1
            indice++;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.Read();


        Console.WriteLine();
        //EJERCICIO 2
        Console.WriteLine("EJERCICIO 2 ===================================================");
        Console.WriteLine();
        Console.WriteLine("Ingrese un numero entero positivo: ");
        string input = Console.ReadLine();
        int numero = int.Parse(input);
        int divisor = 1;

        Console.WriteLine("Los divisores de este numero son: ");
        do
        {

            if (numero % divisor == 0)
            {
                Console.Write(divisor + ", ");
            }
            divisor = divisor + 1;


        } while (divisor <= numero);
        Console.WriteLine();



        //EJERCICIO 3
        Console.WriteLine("EJERCICIO 3 ===================================================");
        Console.WriteLine();
        Console.WriteLine("Ingrese un numero entero: ");
        Console.WriteLine();
        string input2 = Console.ReadLine();
        int n = int.Parse(input2);
        int num1 = 0;
        int num2 = 1;
        int numSiguiente;

        Console.WriteLine("Los primeros " + n + " numeros de la serie de Fibonacci son: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(num1 + ", ");
            numSiguiente = num1 + num2;
            num1 = num2;
            num2 = numSiguiente;
        }


        Console.WriteLine();
        //EJERCICIO 4
        Console.WriteLine("EJERCICIO 4 ===================================================");
        Console.WriteLine();
        int numTabla = 1;

        while (numTabla <= 12)
        {
            Console.WriteLine("Tabla del " + numTabla + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numTabla + " x " + i + " = " + (numTabla * i));
            }
            Console.WriteLine();
            numTabla++;
        }
        Console.ReadLine();
    }
}

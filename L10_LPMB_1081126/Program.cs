using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 ===============================================");
        Console.WriteLine();

        int num;

        Console.Write("Ingrese un número entero: ");
        num = int.Parse(Console.ReadLine());

        int resultado = SumaDigitos(num);

        Console.WriteLine();
        Console.WriteLine("La suma de los dígitos es: " + resultado);

        Console.ReadLine();
        Console.Clear();


        // EJERCICIO 2
        Console.WriteLine("EJERCICIO 2 ===============================================");
        Console.WriteLine();

        int saldo, retiro;

        Console.WriteLine("Ingrese el saldo actual: ");
        saldo = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Ingrese el monto a retirar: ");
        retiro = int.Parse(Console.ReadLine());

        string mensaje = AjustarSaldo(ref saldo, retiro);

        Console.WriteLine();
        Console.WriteLine(mensaje);
        
        Console.ReadLine();
        Console.Clear();


        // EJERCICIO 3
        Console.WriteLine("EJERCICIO 3 ===============================================");

        double C;
        double F = 0;

        Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
        C = double.Parse(Console.ReadLine());

        string resultadoF = ConvertirCelsiusAFahrenheit(C, ref F);

        Console.WriteLine(resultadoF);

        Console.ReadLine();
        Console.Clear();


        //EJERCICIO 4
        Console.WriteLine("EJERCICIO 4 ===============================================");
        Console.WriteLine();
        
        int puntos;

        Console.WriteLine("Ingrese los puntos iniciales: (1-100)"); //La variable puntos se ingresa pour el usuario para que se puedan evaluar los métodos con diferentes valores de puntos.
        puntos = int.Parse(Console.ReadLine());

        int nuevosPuntos = agregarPuntos(ref puntos);
        Console.WriteLine("Puntos después de agregar: " + nuevosPuntos);

        int puntosRestantes = quitarPuntos(ref puntos);
        Console.WriteLine("Puntos después de quitar: " + puntosRestantes);

        string nivel = obtenerNivel(puntos);
        Console.WriteLine("Nivel actual: " + nivel);

        string estado = evaluarEstado(puntos);
        Console.WriteLine("Estado actual: " + estado);


    }

    static int SumaDigitos(int numero)
    {
        int suma = 0;

        while (numero > 0)
        {
            suma += numero % 10; // Obtener el último dígito y sumarlo
            numero = (numero / 10);

        }
        return suma;
    }

    static string AjustarSaldo(ref int saldo, int retiro)
    {
        if (retiro > saldo)
        {
            return "No se puede realizar el retiro. Saldo insuficiente.";
        }
        else
        {
            saldo = saldo - retiro; // Restar el monto retirado al saldo
            return "Retiro exitoso. Saldo actual: " + saldo;
        }
    }

    static string ConvertirCelsiusAFahrenheit(double celsius, ref double fahrenheit)
    {
        fahrenheit = (celsius * 9 / 5) + 32; // Fórmula de conversión
        return "F = " + fahrenheit;
    }

    static int agregarPuntos(ref int puntos)
    {
        puntos += 10; 

        if (puntos > 100)
        {
            puntos = 100; // Limitar los puntos a un máximo de 100
        }
        return puntos;
    }

    static int quitarPuntos(ref int puntos)
    {
        puntos -= 7; 
        if (puntos < 0)
        {
            puntos = 0; // Limitar los puntos a un mínimo de 0
        }
        return puntos;
    }

    static string obtenerNivel(int puntos)
    {
        if (puntos >= 80)
        {
            return "Avanzado";
        }
        else if (puntos >= 50)
        {
            return "Intermedio";
        }
        else
        {
            return "Básico";
        }
    }

    static string evaluarEstado(int puntos)
    {
        if (puntos == 100)
        {
            return "Excelente";
        }
        else if (puntos >= 70)
        {
            return "Aprobado";
        }
        else if (puntos >= 1)
        {
            return "Reprobado";
        }
        else
        {
            return "Sin puntos";
        }
    }
} 
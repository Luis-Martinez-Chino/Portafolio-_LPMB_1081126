using System;
class Program
{
    static void Main()
    {
        //EJERCICIO 1 ================================================================================================

        int[,] matriz = new int[5, 5];

        Console.WriteLine("EJERCICIO 1 ============================================");
        Console.WriteLine();

        llenar(matriz);

        Console.WriteLine("Suma de la diagonal principal: " + sumaDiagonalPrincipal(matriz));
        Console.WriteLine();
        Console.WriteLine("La suma de la diagonal secundaria es: " + sumaDiagonalSecundaria(matriz));

        //EJERCICIO 2 ===============================================================================================
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 2 ============================================");
        Console.WriteLine();

        int[,] matriz2 = new int[4, 6];


        llenar2(matriz2);

        Console.WriteLine("La cantidad de números pares es: " + numerosPares(matriz2));
        Console.WriteLine();
        Console.WriteLine("La cantidad de números impares es: " + numerosImpares(matriz2));


        //EJERCICIO 3 ================================================================================================
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 3 ============================================");
        Console.WriteLine();

        float [,] matriz3 = new float[5, 4];
        float promedioEstudiante;

        llenar3(matriz3);

        for (int i = 0; i < matriz3.GetLength(0); i ++)
        {
            promedioEstudiante = promedio(matriz3, i);

            Console.WriteLine("El promedio del estudiante " + (i + 1) + " es: " + promedioEstudiante);

            if (aprueba(promedioEstudiante))
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante " + (i + 1) + " aprueba.");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("El estudiante " + (i + 1) + " reprueba.");
            }

        }

        //EJERCICIO 4 ================================================================================================
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 4 ============================================");
        Console.WriteLine();

        int[,] matriz4 = new int[3, 3];

        llenar4(matriz4);

        if (matrizSimetricaenejeY(matriz4) == false)
        {
            Console.WriteLine("La matriz no es simetrica en el eje Y.");
        }

        else
        {
            Console.WriteLine("La matriz es simetrica en el eje Y.");
        }

        Console.Read();
    }
    static int sumaDiagonalPrincipal(int[,] matriz) //EJERCICIO 1 FUNCIONES
    {
        int suma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            suma += matriz[i, i];
        }
        return suma;
    } 

    static int sumaDiagonalSecundaria(int[,] matriz) //EJERCICIO 1 FUNCIONES
    {
        int suma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            suma += matriz[i, matriz.GetLength(1) - 1 - i];
        }
        return suma;
    }

    static void llenar(int[,] matriz) // EJERCICIO 1 PROCEDIMIENTO
    {
        Console.WriteLine("Ingrese los 25 elementos de la matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {

                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    } 

    static void llenar2(int[,] matriz) // EJERCICIO 2 PROCEDIMIENTO
    {
        Console.WriteLine("Ingrese los 24 elementos de la matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }


    static int numerosPares(int[,] matriz) // EJERCICIO 2 FUNCIONES
    {
        int contadorPares = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    contadorPares++;
                }
            }
        }
        return contadorPares;
    }

    static int numerosImpares(int[,] matriz) // EJERCICIO 2 FUNCIONES
    {
        int contadorImpares = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 != 0)
                {
                    contadorImpares++;
                }
            }
        }
        return contadorImpares;
    }

    static void llenar3(float[,] matriz) //EJERCICIO 3 PROCEDIMIENTO
    {
        Console.WriteLine("Ingrese los 20 elementos de la matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = float.Parse(Console.ReadLine());
            }
        }
    }

    static float promedio(float[,] matriz, int estudiante) //EJERCICIO 3 FUNCION
    {
        float suma = 0;
        float promedio;

        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            suma += matriz[estudiante, j];
        }

        promedio = suma / matriz.GetLength(1);
        return promedio;
    }

    static bool aprueba(float promedio)
    {
        return promedio >= 61; // Devuelve true si el promedio es mayor o igual a 61, de lo contrario devuelve false 
    }
    static void llenar4(int[,] matriz) //EJERCICIO 4 PROCEDIMIENTO
    {
        Console.WriteLine("Ingrese los 9 elementos de la matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static bool matrizSimetricaenejeY (int[,] matriz) //EJERCICIO 4 FUNCION
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1) / 2; j++)
            {
                if (matriz[i, j] != matriz[i, matriz.GetLength(1) - 1 - j])
                {
                    return false; // No es simétrica
                }
            }
        }
        return true; // Es simétrica
    }
}
using System;
class Program
{
    static void Main()
    {

        //EJERCICIO 1
        string palabra;

        Console.WriteLine("EJERCICIO 1 ===================================================");
        Console.WriteLine();
        Console.WriteLine("Ingrese una palabra: ");
        palabra = Console.ReadLine().ToLower();

        char[] caracteres = palabra.ToCharArray(); //CONVERTIR LA PALABRA EN UN ARREGLO DE CARACTERES


        bool esPalindromo = true;

        for (int i = 0; i < caracteres.Length / 2; i++)
        {
            if (caracteres[i] != caracteres[caracteres.Length - 1 - i]) //DETECTAR SI LOS CARACTERES SON DIFERENTES
            {
                esPalindromo = false;
                break;
            }

        }

        if (esPalindromo == true) //SI LA PALABRA ES UN PALÍNDROMO
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else {
            Console.WriteLine("La palabra no es un palíndromo.");
        }

        //EJERCICIO 2
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 2 ===================================================");
        Console.WriteLine();

        // ARREGLOS PARA ALMACENAR LAS PALABRAS EN ESPAÑOL, INGLÉS E ITALIANO

        string[] español = { "rojo", "azul", "amarillo", "blanco", "verde" }; 
        string[] ingles = { "red", "blue", "yellow", "white", "green" };
        string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };

        int opcion;

        do 
        {
            Console.WriteLine("========= MENÚ ==========="); //MENU Y OPCIONES PARA PRACTICAR O TERMINAR LA LECCIÓN
            Console.WriteLine("1. Practicar lección ");
            Console.WriteLine("2. Terminar lección ");
            Console.WriteLine("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) //OPCION PARA PRACTICAR LA LECCIÓN
            {
                Console.WriteLine("Ingrese una palabra en español: ");
                string palabraEspañol = Console.ReadLine().ToLower();

                bool encontrada = false;

                //RECORRIDO DEL ARREGLO
                for (int i = 0; i < español.Length; i++)
                {
                    if (palabraEspañol == español[i])
                    {
                        Console.WriteLine(español[i] + ", " + ingles[i] + ", " + italiano[i]); //SI LA PALABRA SE ENCUENTRA EN EL ARREGLO SE MUESTRA EN LOS 3 IDIOMAS

                        encontrada = true;
                        break;
                    }

                }

                if (encontrada == false)
                {
                    Console.WriteLine("La palabra no se encuentra en la lección actual."); //SI LA PALABRA NO SE ENCUENTRA EN EL ARREGLO SE MUESTRA ESTE MENSAJE
                }
            }

        } while (opcion != 2);

        Console.WriteLine("Lección finalizada. ");


        //EJERCICIO 3
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 3 ===================================================");
        Console.WriteLine();

        int[] calificaciones = new int[10];
        Random random = new Random();
        int opcion2;

        for (int i = 0; i < calificaciones.Length; i++)
        {
            calificaciones[i] = random.Next(50, 101); //GENERAR CALIFICACIONES ALEATORIAS ENTRE 50 Y 100
        }

        do
        {

            Console.WriteLine("========= MENÚ ===========");
            Console.WriteLine("1. Reporte de rendimiento ");
            Console.WriteLine("2. Estadisticas");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Seleccione una opción: ");

            opcion2 = int.Parse(Console.ReadLine());

            switch (opcion2)
            {
                case 1:
                    Console.WriteLine("Calificaciones:");
                    for (int i = 0; i < calificaciones.Length; i++) //COLORES PARA LAS CALIFICACIONES SEGÚN EL RANGO
                    {
                        int nota = calificaciones[i];

                        if (nota >= 50 && nota <= 64)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (nota >= 65 && nota <= 79)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        
                        Console.Write(nota + " ");

                    }

                    Console.ResetColor();
                    Console.WriteLine();
                    break;

                case 2:
                    int suma = 0;
                    int mayor = calificaciones[0];
                    int menor = calificaciones[0];

                    for (int i = 0; i < calificaciones.Length; i++) //CÁLCULO DEL PROMEDIO, CALIFICACIÓN MÁS ALTA Y CALIFICACIÓN MÁS BAJA
                    {
                        
                        suma += calificaciones[i];

                        if (calificaciones[i] > mayor)
                        {
                            mayor = calificaciones[i];
                        }
                        if (calificaciones[i] < menor)
                        {
                            menor = calificaciones[i];
                        }
                    }
                    double promedio = (double)suma / calificaciones.Length;  //CÁLCULO DEL PROMEDIO y MUESTRA DE RESULTADOS
                    Console.WriteLine("Promedio: " + promedio);
                    Console.WriteLine("Calificación más alta: " + mayor); //MUESTRA DE CALIFICACIÓN MÁS ALTA
                    Console.WriteLine("Calificación más baja: " + menor); //MUESTRA DE CALIFICACIÓN MÁS BAJA
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("Programa finalizado."); //OPCIÓN PARA SALIR DEL PROGRAMA
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }

        } while (opcion2 != 3);



        //EJERCICIO 4
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 4 ===================================================");
        string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" }; //ARREGLO PARA LOS NOMBRES DE LOS EMPLEADOS
        double[] salario_x_hora = { 100, 125.50, 98.65, 125, 132.50, 102.50 }; //ARREGLO PARA LOS SALARIOS POR HORA DE CADA EMPLEADO

        double[] horas_laboradas = new double[6]; // ARREGLO PARA ALMACENAR LAS HORAS LABORADAS POR CADA EMPLEADO, SE INICIALIZA CON EL MISMO TAMAÑO QUE LOS OTROS ARREGLOS

        Console.WriteLine("Ingrese las horas laboradas por cada empleado: ");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Horas de {nombres[i]}: ");                  //Para la sintaxis de algunos console.writeline como este se utilizo ayuda de IA. Ejercicio 4
            horas_laboradas[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("===== PAGOS SEMANALES =====");

        for (int i = 0; i < nombres.Length; i++) //CÁLCULO DEL PAGO SEMANAL PARA CADA EMPLEADO, CON CONSIDERACIÓN DE HORAS EXTRA
        {
            double horas = horas_laboradas[i];
            double salario = salario_x_hora[i];
            double pago;

            if (horas > 40) //CÁLCULO DEL PAGO SEMANAL CON Y SIN HORAS EXTRA
            {
                double horas_normales = 40;
                double horas_extra = horas - 40;

                pago = (horas_normales * salario) + (horas_extra * salario * 1.5);
            }
            else 
            {
                pago = horas * salario;
            }

            Console.WriteLine($"{nombres[i]}: Q{pago:F2}"); //MUESTRA DEL PAGO SEMANAL DE CADA EMPLEADO, CON FORMATO DE DOS DECIMALES

        }

    }

}   
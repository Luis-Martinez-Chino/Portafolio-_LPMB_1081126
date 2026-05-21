using System;
class Program
{
    static void Main()
    {
        // Desafío #1: Estructuras Selectivas
        Console.WriteLine("EJERCICIO 1 =====================================");
        Console.WriteLine("Ingrese un número: ");
        string entradaUsuario = Console.ReadLine();
        int numero = int.Parse(entradaUsuario);

        if (numero < 0)
        {
            Console.WriteLine("El número ingresado es un número negativo");
        }

        else if (numero > 0)
        {
            Console.WriteLine("El número ingresado es un número positivo");
        }

        else
        {
            Console.WriteLine("El número ingresado es 0");
        }

        // Entradas: números enteros
        // Salidas: "El número ingresado es un número negativo", "El número ingresado es un número positivo" o "El número ingresado es 0"
        //Procesos: numero < 0, numero > 0, numero == 0

        Console.WriteLine();
        // Desafío #2: Estructuras Selectivas
        Console.WriteLine("EJERCICIO 2 =====================================");
        Console.WriteLine("Ingrese un año: ");
        string entradaAño = Console.ReadLine();
        int año = int.Parse(entradaAño);

        if (año % 400 == 0) {
            Console.WriteLine("El año ingresado es bisiesto");
        }

        else if (año % 100 == 0) {
            Console.WriteLine("El año ingresado no es bisiesto");
        }

        else if (año % 4 == 0) {
            Console.WriteLine("El año ingresado es bisiesto");
        }

        else {
            Console.WriteLine("El año ingresado no es bisiesto");
        }

        // Entradas: años | Salidas: "El año ingresado es bisiesto" o "El año ingresado no es bisiesto"
        //Procesos: año % 400 == 0, año % 100 == 0, año % 4 == 0

        Console.WriteLine();
        // Desafío #3: Estructuras Selectivas
        Console.WriteLine("EJERCICIO 3 =====================================");
        Console.WriteLine("Ingrese su salario mensual: ");
        string entradaIngreso = Console.ReadLine();
        double salario = double.Parse(entradaIngreso);
        Console.WriteLine("¿Usted tiene multa? Esrcibir unicamente Si o No ");
        string entradaMulta = Console.ReadLine();
        bool multa = entradaMulta.ToLower() == "Si";
        
        if (salario <= 500)
        {
            Console.WriteLine("Usted no debe pagar ornato");
        }
        else if (salario > 500 && salario <= 1000) {
            if (!multa)
            {
                Console.WriteLine("Usted debe pagar: Q10.00");
            }
            else
            {
                Console.WriteLine("Usted debe pagar una multa de: Q20.00");
            }
        }

        else if (salario > 1000 && salario <= 3000) {
            if (!multa)
            {
                Console.WriteLine("Usted debe pagar: Q15.00");
            }
            else
            {
                Console.WriteLine("Usted debe pagar una multa de: Q30.00");
            }
        }

        else if (salario > 3000 && salario <= 6000) {
            if (!multa)
            {
                Console.WriteLine("Usted debe pagar: Q50.00");
            }
            else
            {
                Console.WriteLine("Usted debe pagar una multa de: Q100.00");
            }
        }

        else if (salario > 6000 && salario <= 9000) {
            if (!multa)
            {
                Console.WriteLine("Usted debe pagar: Q75.00");
            }
            else
            {
                Console.WriteLine("Usted debe pagar una multa de: Q150.00");
            }
        }

        else if (salario > 9000 && salario <= 12000) {
            if (!multa)
            {
                Console.WriteLine("Usted debe pagar: Q100.00");
            }
            else
            {
                Console.WriteLine("Usted debe pagar una multa de: Q200.00");
            }
        }

        else {               // salario > 12000
            if (!multa) {
                Console.WriteLine("Usted debe pagar: Q150.00");
            }
            else {
                Console.WriteLine("Usted debe pagar una multa de: Q300.00");
            }
        }
        // Entradas: salario mensual, multa (Si o No)
        // Salidas: "Usted no debe pagar ornato" o "Usted debe pagar: Q[valor]"
        // Procesos: salario <= 500, salario > 500 && salario <= 1000, salario > 1000 && salario <= 3000, salario > 3000 && salario <= 6000, salario > 6000 && salario <= 9000, salario > 9000 && salario <= 12000, salario > 12000, multa == "No", multa == "Si"

        Console.WriteLine();
        // Desfío #4: Estructuras Selectivas & Operadores aritméticos
        Console.WriteLine("EJERCICIO 4 =====================================");
        Console.WriteLine("Ingrese la cantidad de horas estacionadas: ");
        string entradaHoras = Console.ReadLine();
        int horas = int.Parse(entradaHoras);

        int montoEstacionamiento = horas * 10;

        Console.WriteLine("El monto por las horas estacionadas es de: " + montoEstacionamiento);
        Console.WriteLine("______________________________________________________________________");
        Console.WriteLine("Ingrese el monto de su pago: ");
        string entradaPago = Console.ReadLine();
        int pago = int.Parse(entradaPago);


        if (pago < montoEstacionamiento && pago >= 0)
        {
            Console.WriteLine("El pago es insuficiente");
        }

        else if (pago == montoEstacionamiento)
        {
            Console.WriteLine("Pago realizado exitosamente, no requiere cambio. Gracias por su pago");
        }

        else if (pago > montoEstacionamiento)
        {
            int cambio = pago - montoEstacionamiento;

            int b100 = cambio / 100;
            cambio = cambio % 100;

            int b50 = cambio / 50;
            cambio = cambio % 50;

            int b20 = cambio / 20;
            cambio = cambio % 20;

            int b10 = cambio / 10;
            cambio = cambio % 10;

            int b5 = cambio / 5;
            cambio = cambio % 5;

            int b1 = cambio;

            Console.WriteLine("Pago realizado exitosamente, su cambio es de: Q" + (pago - montoEstacionamiento));
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Billetes entregados: ");
            Console.WriteLine("Q100: " + b100);
            Console.WriteLine("Q50: " + b50);
            Console.WriteLine("Q20: " + b20);
            Console.WriteLine("Q10: " + b10);
            Console.WriteLine("Q5: " + b5);
            Console.WriteLine("Q1: " + b1);
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Gracias por su pago");
        }

        else {
            Console.WriteLine("Monto de pago no válido");
        }
        //Entradas: horas estacionadas, monto de pago 
        //Salidas: "El pago es insuficiente", "Pago realizado exitosamente, no requiere cambio. Gracias por su pago" o "Pago realizado exitosamente, su cambio es: [monto de cambio]. Gracias por su pago"
        //Procesos: montoEstacionamiento = horas * 10, pago < montoEstacionamiento, pago == montoEstacionamiento, pago > montoEstacionamiento

        //IMPORTANTE: No se tomo en cuenta la entrada de letras ya que al ser una maquina de pago de estacionamiento no seria posible que el usuario ingrese letras.
    }


}

//LUIS PEDRO MARTINEZ BOBADILLA - 1081126
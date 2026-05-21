using System;

class Program
{
    static void Main()
    {
        // EJERCICIO 1
        Console.WriteLine("EJERCICIO 1 ================================================");
        Console.WriteLine();


        // CREACIÓN DE LAS DOS CUENTAS
        CuentaBancaria cuenta1 = new CuentaBancaria("Luis Martinez", "12345-A", 1000.00);
        CuentaBancaria cuenta2 = new CuentaBancaria("Italo Díaz", "67890-B", 500.00);

        // MOSTRAR INFORMACIÓN
        Console.WriteLine("INFORMACIÓN INICIAL:");
        cuenta1.MostrarInformacion();
        cuenta2.MostrarInformacion();


        // REALIZAR DEPÓSITOS Y RETIROS
        // Operación en Cuenta 1
        Console.WriteLine("Saldo inicial: Q" + cuenta1.ObtenerSaldo());
        cuenta1.Depositar(250.00);
        Console.WriteLine("Saldo final: Q" + cuenta1.ObtenerSaldo());

        // Operación en Cuenta 2
        Console.WriteLine("Saldo inicial: Q" + cuenta2.ObtenerSaldo());
        cuenta2.Retirar(100.00);
        Console.WriteLine("Saldo final: Q" + cuenta2.ObtenerSaldo());

        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar.");
        Console.ReadLine();



        //EJERCICIO 2
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 2 ================================================");
        Console.WriteLine();

        // CREAR LOS PRODUCTOS
        Producto prod1 = new Producto("Laptop Gamer", 8500.00, 10);
        Producto prod2 = new Producto("Mouse Inalámbrico", 150.00, 25);

        // MOSTRAR INFORMACIÓN INICIAL
        Console.WriteLine("INVENTARIO INICIAL:");
        prod1.MostrarInformacion();
        prod2.MostrarInformacion();

        // REALIZAR UNA VENTA (Producto 1)
        Console.WriteLine("\n>>> PROCESANDO VENTA:");
        Console.WriteLine("Cantidad inicial de " + prod1.ObtenerCantidad()); // Muestra cambios
        prod1.Vender(3);
        Console.WriteLine("Cantidad final: " + prod1.ObtenerCantidad());

        // REALIZAR UN REABASTECIMIENTO (Producto 2)
        Console.WriteLine("\n>>> PROCESANDO REABASTECIMIENTO:");
        Console.WriteLine("Cantidad inicial de " + prod2.ObtenerCantidad());
        prod2.Reabastecer(15);
        Console.WriteLine("Cantidad final: " + prod2.ObtenerCantidad());

        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar.");
        Console.ReadLine();



        // EJERCICIO 3
        Console.WriteLine();
        Console.WriteLine("EJERCICIO 3 ================================================");
        Console.WriteLine();

        // CREAR NOTAS Y ESTUDIANTES
        double[] notasEst1 = { 70.5, 80.0, 95.0 };

        Estudiante est1 = new Estudiante("Carlos Angulo", 19, "Segundo Año", notasEst1);

        double[] notasEst2 = { 65.0, 65.5, 74.0 };
        Estudiante est2 = new Estudiante("María Montoya", 20, "Tercer Año", notasEst2);

        // CALCULAR PROMEDIOS Y APROBACIÓN
        double promedioEst1 = est1.CalcularPromedio();
        double promedioEst2 = est2.CalcularPromedio();



        // MOSTRAR INFORMACIÓN INICIAL
        Console.WriteLine("INFORMACIÓN ACADÉMICA INICIAL:");
        est1.MostrarInformacion(promedioEst1);
        est2.MostrarInformacion(promedioEst2);

        // AGREGAR NOTA NUEVA A EST1
        Console.WriteLine("\n>>> ACTUALIZANDO NOTAS DEL ESTUDIANTE 1 ");
        est1.AgregarNota(90.0);

        // 4. Mostrar el resultado actualizado
        Console.WriteLine("\nRESULTADO ACTUALIZADO:");
        double nuevoPromedioEst1 = est1.CalcularPromedio();
        est1.MostrarInformacion(nuevoPromedioEst1);

        Console.WriteLine("\nPresione ENTER para finalizar.");
        Console.ReadLine();
    }
}
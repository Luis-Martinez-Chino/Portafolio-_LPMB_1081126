using System;

class Program
{
    static void Main()
    {
        // Problema #3
        Console.WriteLine("PROBLEMA 3 ===================================================================================");
        Console.WriteLine();
        Console.WriteLine("Ingrese su tipo de sangre: ");
        string tipoSangre = Console.ReadLine();

        if (tipoSangre == "AB")
        {
            Console.WriteLine("Su tipo de sangre es compatible con todos los demás tipos para transfuciónes sanguíneas");
        }
        else if (tipoSangre == "AB-")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O-, B-, A- y AB-");
        }
        else if (tipoSangre == "A+")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O-, O+, A- y A+");
        }
        else if (tipoSangre == "A-")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O- y A-");
        }
        else if (tipoSangre == "B+")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O-, O+, B- y B+");
        }
        else if (tipoSangre == "B-")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O- y B-");
        }
        else if (tipoSangre == "O+")
        {
            Console.WriteLine("Su tipo de sangre es compatible con los tipos: O- y O+");
        }
        else if (tipoSangre == "O-")
        {
            Console.WriteLine("Su tipo de sangre es compatible solo con el tipo: O-");
        }
        else
        {
            Console.WriteLine("Tipo de sangre no reconocido.");
        }

        Console.WriteLine();

        Console.WriteLine("PROBLEMA 4 ===================================================================================");
        Console.WriteLine();
        Console.WriteLine("Ingrese el tipo de cliente: Cliente regular: 1 | Cliente VIP: 2");
        string tipoCliente = Console.ReadLine();
        Console.Write("Ingrese la cantidad de productos a comprar: ");
        string cantidadProductos = Console.ReadLine();
        int productos = int.Parse(cantidadProductos);
        Console.WriteLine("Ingrese el monto de la compra: ");
        string monto = Console.ReadLine();
        double montoCompra = double.Parse(monto);

        if (productos < 100)
        {
            if (tipoCliente == "1")
            {
                montoCompra = montoCompra * 0.95;
                Console.WriteLine("El monto a pagar con el descuento del 5% es: " + montoCompra);
            }
            else if (tipoCliente == "2")
            {
                montoCompra = montoCompra * 0.90;
                Console.WriteLine("El monto a pagar con el descuento del 10% es: " + montoCompra);

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        else if (productos >= 100)
        {
            montoCompra = montoCompra * 0.85;
            Console.WriteLine("El monto a pagar con el descuento del 15% es: " + montoCompra);
        }

        else {
            Console.WriteLine("Error");
        }
    }
}

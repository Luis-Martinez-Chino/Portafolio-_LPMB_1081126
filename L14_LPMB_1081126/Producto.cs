using System;

public class Producto
{

    string nombre;
    double precio;
    int cantidad;

    public Producto(string nombre, double precio, int cantidad)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: Q" + precio);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("----------------------------------");

    }

    public void Vender(int cantidadVendida)
    {
        if (cantidadVendida <= cantidad)
        {
            cantidad -= cantidadVendida;
            Console.WriteLine("Venta exitosa de: " + cantidadVendida + " unidades.");
        }
        else
        {
            Console.WriteLine("Error: No hay suficiente stock para vender.");
        }
    }

    public void Reabastecer(int cantidadReabastecida)
    {
        if (cantidadReabastecida > 0)
        {
            cantidad += cantidadReabastecida;
            Console.WriteLine("Reabastecimiento exitoso de: " + cantidadReabastecida + " unidades.");
        }
    }

    public int ObtenerCantidad()
    {
        return cantidad;
    }
}

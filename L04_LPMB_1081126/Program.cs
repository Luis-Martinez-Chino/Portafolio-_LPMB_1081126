using System;
class Program
{
    static void Main()
    {
        // 1. Perfil de un Personaje
        string nombre = "Chino";
        int nivel = 50;
        double hp = 80.5;
        bool es_un_jefe = false;
        Console.WriteLine("Character: " + nombre + "| Level: " + nivel + "| HP: " + hp + "| ¿Es un jefe? " + es_un_jefe);
        Console.ReadLine();

        // 2. Conversación Implícita
        int numeroEntero = 1500;
        long numeroLargo;
        numeroLargo = numeroEntero;
        Console.WriteLine(numeroLargo);
        Console.ReadLine();
        double numeroDecimal;
        numeroDecimal = numeroLargo;
        Console.WriteLine(numeroDecimal);
        Console.ReadLine();

        // 3. Conversión Explicita
        double precioExacto = 45.89;
        int precioRedondeado;
        precioRedondeado = (int)precioExacto;
        Console.WriteLine("Precio exacto: " + precioExacto + "| Precio redondeado: " + precioRedondeado);
        Console.ReadLine();

        //¿Qué sucede con los decimales? Los decimales desaparecen porque el precio se redondeó a un número entero.


        // 4. Método Parse
        Console.WriteLine("Ingrese un número: ");
        string entradaUsuario = Console.ReadLine();
        int numero = int.Parse(entradaUsuario);
        numero = numero + 5;
        Console.WriteLine("El número ingresado + 5 es: " + numero);
        Console.ReadLine();

        // ¿Por qué aparece el error de la otra forma? De esa forma la conversion de tipos de variables no se puede realizar

        // ¿Qué descripción nos retorna C#? No se puede convertir implícitamente el tipo "string" en "int"



        // 5. Clase Convert
        string valorTexto = "true";
        bool valorBooleano = Convert.ToBoolean(valorTexto);
        string valorDecimal = "25.5";
        double valorDouble = Convert.ToDouble(valorDecimal);
        Console.WriteLine("Valor Booleano: " + valorBooleano + "| Valor Double: " + valorDouble);
        Console.ReadLine();

        // 6. Conversion a texto (.ToString)
        double pi = 3.1416;
        string cadena = pi.ToString("F2");
        Console.WriteLine("pi es igual a: " + cadena);
        Console.ReadLine();

        // 7. Calculadora de IVA
        string precioProducto;
        Console.WriteLine("Ingrese el precio del producto: ");
        precioProducto = Console.ReadLine();
        double precioDouble = Convert.ToDouble(precioProducto);
        double iva = precioDouble * 0.21;
        double precioTotal = precioDouble + iva;
        precioTotal = (int)precioTotal;
        Console.WriteLine("El total a pagar es: " + precioTotal);
        Console.ReadLine();
    }
}





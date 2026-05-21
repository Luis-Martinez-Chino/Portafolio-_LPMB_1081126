using System;

    public class CuentaBancaria
    {
        string titular;
        string numeroCuenta;
        double saldo;

        public CuentaBancaria(string nombre, string cuenta, double saldoInicial)
        {
            titular = nombre;
            numeroCuenta = cuenta;
            saldo = saldoInicial;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("No. Cuenta: " + numeroCuenta);
            Console.WriteLine("Saldo Actual: Q" + saldo);
            Console.WriteLine("----------------------------------");
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine("Depósito exitoso de: Q" + monto);
            }
        }

        public void Retirar(double monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                Console.WriteLine("Retiro exitoso de: Q" + monto);
            }
            else
            {
                Console.WriteLine("Error: Fondos insuficientes.");
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }
    }

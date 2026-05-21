using System;
    public class Estudiante
    {

        string nombre;
        int edad;
        string grado;
        double[] notas;
        public Estudiante(string nombre, int edad, string grado, double[] notasIniciales)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notasIniciales;
        }

        public double CalcularPromedio()
        {
            if (notas.Length == 0) return 0;
            double suma = 0;
            foreach (double nota in notas)
            {
                suma += nota;
            }
            return suma / notas.Length;

        }
        public bool Aprobo()
        {
            bool resultado = CalcularPromedio() >= 61;

            return resultado;
        }


        public void AgregarNota(double nuevaNota)
        {
            Array.Resize(ref notas, notas.Length + 1); //Sugerida por GitHub Copilot
        notas[notas.Length - 1] = nuevaNota;
        }

    public void MostrarInformacion(double promedioCalculado)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Estudiante: " + nombre);
            Console.WriteLine("Edad: " + edad + " | Grado: " + grado);
            Console.WriteLine("Promedio: " + promedioCalculado.ToString("F2"));
            Console.WriteLine("Estado: " + (Aprobo() ? "APROBADO" : "REPROBADO")); //Sugerida por GitHub Copilot
            Console.WriteLine("----------------------------------");
        }
    }


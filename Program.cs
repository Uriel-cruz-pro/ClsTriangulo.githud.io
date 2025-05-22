using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClsTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsTriangulo triangulo = new ClsTriangulo();

            // Pedir valores al usuario
            Console.WriteLine("Ingrese el primer lado del triángulo:");
            triangulo.setLadoA(Convert.ToSingle(Console.ReadLine()));

            Console.WriteLine("Ingrese el segundo lado del triángulo:");
            triangulo.setLadoB(Convert.ToSingle(Console.ReadLine()));

            Console.WriteLine("Ingrese el tercer lado del triángulo:");
            triangulo.setLadoC(Convert.ToSingle(Console.ReadLine()));

            // Mostrar los resultados
            Console.WriteLine($"\nPerímetro: {triangulo.perimetro()}");
            Console.WriteLine($"Área: {triangulo.area()}");
            Console.WriteLine($"Tipo de Triángulo: {triangulo.definirTipoTriangulo()}");
            Console.ReadKey();
        }
    }
}


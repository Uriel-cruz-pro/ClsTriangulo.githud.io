using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsTriangulo
{
    class ClsTriangulo
    {
        // Atributos privados
        private float LadoA;
        private float LadoB;
        private float LadoC;

        // Métodos para acceder a los atributos
        public float getLadoA()
        {
            return LadoA;
        }

        public void setLadoA(float valor)
        {
            LadoA = valor;
        }

        public float getLadoB()
        {
            return LadoB;
        }

        public void setLadoB(float valor)
        {
            LadoB = valor;
        }

        public float getLadoC()
        {
            return LadoC;
        }

        public void setLadoC(float valor)
        {
            LadoC = valor;
        }

        // Constructor por defecto
        public ClsTriangulo()
        {
            LadoA = 0;
            LadoB = 0;
            LadoC = 0;
        }

        // Método para calcular el perímetro
        public float perimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        // Método para calcular el área usando la fórmula de Herón
        public double area()
        {
            double s = perimetro() / 2;
            return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        // Método para determinar el tipo de triángulo
        public string definirTipoTriangulo()
        {
            if (LadoA + LadoB <= LadoC || LadoA + LadoC <= LadoB || LadoB + LadoC <= LadoA)
            {
                return "Los valores ingresados no forman un triángulo válido.";
            }
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "Equilátero";
            }
            else if (LadoA == LadoB || LadoB == LadoC || LadoA == LadoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }

}

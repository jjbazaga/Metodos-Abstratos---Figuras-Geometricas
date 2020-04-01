using System;
using MetodoAbstrato.Entidades.Enumerador;

namespace MetodoAbstrato.Entidades
{
    class Triangulo : Figura
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC, Cores cor)
            : base (cor)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        
        public override double Area()
        {
            double p = ((LadoA + LadoB + LadoC) / 2.0);
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }
    }
}
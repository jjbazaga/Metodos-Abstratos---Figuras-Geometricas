using System;
using MetodoAbstrato.Entidades.Enumerador;

namespace MetodoAbstrato.Entidades
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cores cor)
            : base (cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
using MetodoAbstrato.Entidades.Enumerador;

namespace MetodoAbstrato.Entidades
{
    abstract class Figura
    {
        public Cores Cor { get; set; }

        public Figura(Cores cor)
        {
            Cor = cor;
        }
        public abstract double Area();
    }
}
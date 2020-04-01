using System;
using System.Globalization;
using System.Collections.Generic;
using MetodoAbstrato.Entidades;
using MetodoAbstrato.Entidades.Enumerador;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();
            
            Console.Write("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i}: ");
                Console.Write("Retângulo, Circulo ou Triângulo (r/c/t)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Qual a cor: Preta/Azul/Vermelha)? ");
                Cores cor = Enum.Parse<Cores>(Console.ReadLine());
                if(resp == 'r')
                {
                    Console.Write("Entre largura do retângulo: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Entre altura do retângulo: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else if(resp == 'c')
                {
                    Console.Write("Entre o raio do circulo: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }
                else if(resp == 't')
                {
                    Console.Write("Entre o primeiro lado do triângulo: ");
                    double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Entre o segundo lado do triângulo: ");
                    double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Entre o terceiro lado do triângulo: ");
                    double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Triangulo(ladoA, ladoB, ladoC, cor));
                }
                else { Console.WriteLine("Nenhuma figura sugerida foi mencionada, vou INTERROMPER!" );
                }
            }
            Console.WriteLine();
            Console.WriteLine("ÁREAS DAS FIGURAS:");
            foreach(Figura obj in list)
            {
                Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
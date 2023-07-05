
using Treinamentos_e_Aulas;
using System;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Voltando os Estudos");

        Triangulo x, y;

        x = new Triangulo();
        y = new Triangulo();

        Console.WriteLine("Digite o valor o primeiro valor do triangulo 1.");
        x.A = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor o segundo valor do triangulo 1.");
        x.B = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor o terceiro valor do triangulo 1.");
        x.C = double.Parse(Console.ReadLine());

        double AreaTriangulo1 = Triangulo.AreaTriangulo(x.A, x.B, x.C);

        Console.WriteLine(AreaTriangulo1.ToString("F2"));
    }
}
namespace Treinamentos_e_Aulas
{
 class Triangulo
 {
    public double A;
    public double B;
    public double C;

    public static double AreaTriangulo (double a, double b, double c)
    {
        double p = (a+b+c)/2;

        double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

        return area;
    }
 }

}
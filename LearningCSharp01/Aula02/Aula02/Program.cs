internal class Program
{
    private static void Main(string[] args)
    {
        int num1 = 30;
        int num2 = 45;

        int soma = num1 + num2;

        string name = "Luiz";

        Console.WriteLine(name + ", a soma dos números é igual a " + soma);

        double b, B, h, area;
        b = 6.0;
        B = 8.0;
        h = 5.0;

        area = (b + B) / 2.0 * h;

        Console.WriteLine(area);

        int numA, numB;
        double resultado;

        numA = 5;
        numB = 2;

        resultado = (double) numA / numB;

        Console.WriteLine(resultado);

        double testA;
        int testB;

        testA = 5.0;
        testB = (int) testA;

        Console.WriteLine(testB);
    }
}
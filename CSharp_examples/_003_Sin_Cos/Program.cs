namespace _003_Sin_Cos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;

            result = System.Math.Sin(3.14 / 6);
            System.Console.WriteLine(result);

            double angle;
            System.Console.Write("Lütfen radyan cinsinden açı giriniz : ");
            angle = double.Parse(System.Console.ReadLine());
            result = System.Math.Pow(System.Math.Sin(angle), 2);
            System.Console.WriteLine(result);
        }
    }
}

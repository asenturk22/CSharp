namespace _003_Sqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val, result;

            System.Console.Write("Lütfen bir sayi giriniz : ");
            val = double.Parse(System.Console.ReadLine());  

            result = System.Math.Sqrt(val);
            System.Console.WriteLine(result);
        }
    }
}

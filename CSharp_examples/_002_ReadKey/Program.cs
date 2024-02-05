namespace _002_ReadKey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;

            System.Console.Write("Bir değer giriniz: ");
            val = int.Parse(Console.ReadLine());
            System.Console.WriteLine(val * val);
        }
    }
}

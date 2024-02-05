namespace _002_SinfCalismasi
{
    public class Program
    {
        /*
         a, b, ve c isimli double türden 3 değişken bildiriniz. Sonra a ve b için klavyeden değer
okuyunuz. Sonra da bunları çarparak sonucu c'ye atayınız ve c'yi yazdırınız.
         */
        static void Main(string[] args)
        {
            double a, b, c;
            System.Console.Write("1. degeri gir : ");
            a = double.Parse(System.Console.ReadLine());
            System.Console.Write("2. degeri gir : ");
            b = double.Parse(System.Console.ReadLine());
            c = a * b;
            System.Console.WriteLine(c);
        }
    }
}

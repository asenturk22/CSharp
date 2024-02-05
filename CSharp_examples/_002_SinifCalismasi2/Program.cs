namespace _002_SinifCalismasi2
{
    public class Program
    {
        /*
         Sınıf Çalışması: Sample sınıfının içerisinde Square isimli bir metot yazınız. 
            Metodun geri dönüş değeri double türden olsun. Metot içerisinde klavyeden 
            bir double bir değer isteyiniz ve o double değerin karesiyle
            metodu geri döndürünüz. Sonra Main metodundan Square metodunu çağırıp geri
            dönüş değerini yazdırınız.
         */
        static void Main(string[] args)
        {
            double result;

            result = Sample.Square();
            Console.WriteLine(result);
        }
    }
    
    public class Sample
    {
        public static double Square()
        {
            double a; 
            System.Console.WriteLine("a: ");
            a = double.Parse(System.Console.ReadLine());

            return a * a;
        }
    }
}

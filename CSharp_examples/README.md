Program notepad gibi bir editörde yazılır ve uygun yere .cs uzantısıyla save edilir (örneğin Program_.cs olsun).
Bir C# programını IDE olmadan derlemek için öncelikle komut satırına geçmek gerekir. Komut satırı
“cmd.exe” isimli programdır.  Programın yazılacağı dizine geçilir.  

* Bir dosyanın içini görüntülemek için <span style="font-weight: bold; background-color: green;">type</span> komutundan faydalanılır. 


```bash
type Program.cs
```

Program aşağıdaki gibi derlenir. 
```bash
csc Program.cs
```
Microsoft’un C# derleyicisinin ismi “csc.exe” biçimindedir. Bu komutla biz “csc.exe” derleyicisini
çalıştırarak onun “Sample.cs” dosyasını derlemesini sağlamaktayız. İşlem başarılı olursa “.exe” uzantılı bir
dosya oluşacaktır. Bu dosyanın ismini yazıp ENTER tuşuna basarsak program çalışır:

```bash
D:\CSharp\CSharp_examples\_001_HelloWorld\Program
```

# Merhaba Dünya Programının Açıklaması

Bir C# programı kabaca isim alanlarından (namespace'lerden), isim alanları sınıflardan (class'lardan),
sınıflar da metotlardan oluşur. Bir isim alanı bildiriminin genel biçimi şöyledir:

```C#
namespace <isim alanı ismi>
{
    //...
}
```

Sınıf bildirimin genel biçimi de şöyledir:

```C#
class <sınıf ismi>
{
    //...
}
```
Metot bildirimlerinin ise genel biçimi şöyledir:
```C#
[erişim belirleyici] [static] <geri dönüş değerinin türü> <metot ismi>([parametre bildirimi])
{
    //...
}
```

Buradaki erişim belirleyicisi aşağıdaki anahtar sözcüklerden biri olabilir:
Metot bildirimlerinin ise genel biçimi şöyledir:
```C#
public
protected
private
internal
protected internal
```

Erişim belirleyicisinin hiç yazılmaması ile private yazılması aynı anlama gelmektedir (yani erişim
belirleyicisinin default durumu private'tir.).

Bir metot static olabilir ya da olmayabilir. static olmayan metotlara C# standartlarında İngilizce "instance
method" denilmektedir.

C#'ta iki küme parantezi arasındaki bölgeye blok (block) denilmaktedir. Pek çok sentaktik yapı blok içerir.
Örneğin isim alanlarının, sınıfların ve metotların blokları vardır

C#'ta altprogramlara metot (method) denilmektedir. İç içe metotlar bildirilemez. Metotlar sınıf içerisinde
bildirilirler.

C# programları Main isimli özel bir metottan çalışmaya başlar. Main metodu herhangi bir isim alanındaki
herhangi bir sınıfın içerisinde bulunabilir. Main metodu static olmak zorundadır fakat public olmak zorunda
değildir. Şüphesiz bir programda "bir ve yalnızca bir tane" Main metodu bulunmak zorundadır.

Bir C# programı Main metodundan çalışmaya başlar. Main metodu bitince program da biter. Akış metoda
girdiğinde soldan-sağa ve yukarıdan aşağıya sırasıyla deyimleri çalıştırarak ilerler.

Bir metodun bildirilmesi (declaration) demek onun bizim tarafımızdan yazılması demektir. Çağrılması
(calling) demek onun çalıştırılması demektir. Şüphesiz var olan yani bildirilmiş olan metotlar çağrılabilir.
static metot çağırmanın genel biçimi şöyledir:


```C#
[isim alanı ismi][.][sınıf ismi][.]<metot ismi>([argüman listesi]);
```

Bir C# programında istenildiği kadar çok isim alanı, bir isim alanında istenildiği kadar çok sınıf ve bir sınıfta
da istenildiği kadar çok metot bulunabilir. Fakat programın akışı her zaman Main isimli metottan
başlayacaktır. Örneğin:


```C#
namespace CSD
{
    class App
    {
        public static void Main()
        {
            System.Console.WriteLine("Merhaba Dunya");
            Test.Sample.Foo();
        }
    }
}

namespace Test
{
    class Sample
    {
        public static void Foo()
        {
            System.Console.WriteLine("Foo");
        }
    }
}
```

## C#'ın Temel Türleri

Tür (type) bir değişkenin bellekte kaç byte yer kapladığını, ona hangi formatta ve hangi sınırlarda değerlerin
atanabileceğini, onunla hangi işlemlerin yapılabileceğini belirten önemli bir bilgidir. C#'ta her değişkenin ve
ifadenin bir türü vardır. C# katı bir tür kontrolünün uygulandığı (strongle typed) static tür sistemine (static
type system) bir dildir. C# gibi dillerde ifadelerin türleri daha derleme aşamasında belirlenir. Bir daha da
değiştirilemez.

C#'ın temel türleri aşağıdaki tabloda açıklanmaktadır.

| Tür Belirten  Anahtar Sözcük | Byte Uzunluğu | Yapı Karşılığı | Sınır Değerler |
|------------------------------|---------------|----------------|----------------|
| int | 4 | System.Int32 |  [-2147483648, +2147483647]|
|uint| 4 |System.UInt32 | [0, +4294967295]|
|short |2 |System.Int16| [-32768, +32767]|
|ushort | 2 | System.UInt16 | [0, +65535]|
|long | 8| System.Int64| [-9223372036854775808, +9223372036854775807]|
|ulong |8 S|ystem.UInt64 |[0,+ 18446744073709551615]|
|sbyte| 1 |System.SByte |[-128, +127]|
|byte |1 S|ystem.Byte [0|, +255]|
|char |2 S|ystem.Char [0|, +65535]|
|float |4 S|ystem.Single |[±3.6*10-38, ±3.6*10+38]|
|double |8 S|ystem.Double |[±1.6*10-308, ±1.6*10+308]|
|decimal |16 |System.Decima|l ±28 digit mantis|
|bool| 1| System.Boolean| true, false|


## Bildirim İşlemleri

Katı tür kontrolünün uygulandığı dillerde bir değişkeni kullanmadan önce onu derleyiciye tanıtmak gerekir.
Kullanılmadan önce değişkenlerin derleyiciye tanıtılması işlemine bildirim (declaration) denilmektedir. C#'ta
bir değişkeni ancak bildirdikten sonra kullanabiliriz. Bildirim işleminin genel biçimi şöyledir:

```c#
<tür> <değişken listesi>;

int a;
long b, c, d;

```

Bildirimler C#'ta üç yerde yapılabilir:

1- Metotların içerisinde (yani metotların ana bloğunun içerisinde). Örneğin:

```c#
class Sample
{
    public static void Foo()
    {
        int a;
        //...
    }
}
```

2- Metotların dışında fakat sınıf bildiriminin içerisinde. Örneğin:
```c#
class Sample
{
    int x;
    public static void Foo()
    {
        //...
    }
}
```

3- Metotların parametre parantezleri içerisinde. Örneğin:
```c#
class Sample
{
    public static void Foo(int a)
    {
        //...
    }
}
```

Metotların içerisinde yapılan bildirimlere yerel bildirimler (local declarations), bildirilen değişkenlere de yerel
değişkenler (local variables) denilmektedir. Sınıfların içerisinde bildirilen değişkenlere sınıfın veri elemanları
(class fields), parametre parantezlerinin içerisinde bildirilen değişkenlere de "parametre değişkenleri
(paremeters)" denilmektedir.

## Değişkenlere İlkdeğer Verilmesi (Initialization)

Bir değişkene bildirim sırasında ‘=’ operatörü ile ilkdeğer verebiliriz. Örneğin:

```c#
int a = 10;
int x, y = 20, z;
```

## Yerel Değişkenlerin Faaliyet Alanları

Bildirilen bir değişken programın her yerinde kullanılamaz. Bir değişkenin kullanılabildiği program aralığına
faaliyet alanı (scope) denilmektedir. Yerel değişkenler bildirildikleri noktadan itibaren bildirildikleri bloğun
sonuna kadarki bölümde kullanılabilirler. Örneğin:

```c#
namespace CSD
{
    class App
    {
        public static void Main()
        {
            int x;
            x = 10;
            System.Console.WriteLine(x);
        }

        public static void Foo()
        {
            System.Console.WriteLine(x); // error!
        }
    }
}
```

## İfade Kavramı (Expressions)

İfade kavramı programlamadaki en önemli kavramlardan biridir. Değişkenlerin, operatörlerin ve sabitlerin
herbir birleşimine ifade (expression) denir. Örneğin:

```c#
a
100
a + 100
a + b +
```
birer ifadedir. Tek başına sabit ve tek başına değişken ifade belirtir. Fakat tek başına operatör ifade
belirtmez.

## Metotların Geri Dönüş Değerleri (return values)

Bir metodu çağırdıktan sonra metodun çalışması bittiğinde metot bize bir değer verebilir. Bu değere
metodun geri dönüş değeri (return value) denilmektedir. Metodun geri dönüş değerinin türü metot
bildiriminde metot isminin soluna yazılır. Örneğin:

```c#
public static int Foo()
{
    //...
}
```


Burada Foo metodu int türden bir değer geri döndürmektedir. Metotların geri dönüş değerleri işlemlere
sokulabilir.

```c#
x = Foo() * 2;
```

Metotların geri dönüş değerleri return deyimiyle oluşturulmaktadır. return deyiminin genel biçimi şöyledir:

```c#
return [ifade];

namespace CSD
{
    class App
    {
        public static void Main()
        {
            int result;
            result = Sample.Foo() * 2;
            System.Console.WriteLine(result);
        }
    }

    class Sample
    {
        public static int Foo()
        {
            System.Console.WriteLine("Foo");
            return 100;
        }
    }
}
```

return deyiminin iki işlevi vardır:
1) Metodu sonlandırır.
2) Metodun geri dönüş değerini oluşturur.

## Klavyeden Değer Okunması

Klavyeden T türünden bir değer okumak için aşağıdaki kalıp kullanılır:

```c#
val = T.Parse(System.Console.ReadLine());
```

Örneğin:

```c#
namespace CSD
{
    class App
    {
        public static void Main()
        {
            int val;
            System.Console.Write("Bir deger giriniz:");
            val = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(val * val);
        }
    }
}
```

## Henüz Değer Atanmamış Değişkenlerin Kullanılması


C#, Java ve Swift dillerde bir değişkene henüz değer atamamışsak onu içindeki değerin kullanılacağı bir
ifadede kullanamayız. Eğer kullanırsak derleme aşamasında error oluşur. Örneğin:

```c#
namespace CSD
{
    class App
    {
        public static void Main()
        {
            int a;
            System.Console.WriteLine(a); // error: Use of unassigned local variable 'a'
        }
    }
}
```


## Bazı Matematiksel Metotlar

System isim alanı içerisindeki Math isimli sınıfın static metotları önemli bazı matematiksel işlemleri
yapmaktadır. Bunlardan bazılarını gözden geçirelim:

- ### Sqrt() 

Sqrt metodu double bir değerin karekökünü alıp bize onu geri dönüş değeri olarak verir. Parametrik yapısı
şöyledir:

```c#
public static double Sqrt(double val)
```

- ### Pow()

Pow isimli metot kuvvet alma işlemi yapar. Metodun iki double türden parametresi vardır. Metot birinci
parametresiyle belirtilen değerin ikinci parametresiyle belirtilen kuvvetini alır ve geri dönüş değeri olarak
verir

```c#
public static double Pow(double a, double b)
```

- ### Sin(), Cos(), Tan(), ASin(), ACos()

Sin, Cos, Tan, ASin, ACos, Atan trigonometrik işlemleri yapar. Bunlar double parametre alıp double değer
verirler. Parametre radyan cinsinden açı belirtir.  


# Exception Kavramı


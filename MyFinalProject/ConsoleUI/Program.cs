using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //IoC
            //CategoryTest();

            Console.WriteLine("Hello, World!");
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
        private static ProductManager ProductTest()
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            ProductManager productManager = new ProductManager(new EfProductDal());

            //Tüm ürünleri getir.
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

            Console.WriteLine("\n\n********** Kategori ***********");


            //Kategori No = 2 olan ürünlerin tamamını getir. 
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }


            Console.WriteLine("\n\n************ Ürün Fiyatına Göre ************");
            //Kategori No = 2 olan ürünlerin tamamını getir. 
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }

            return productManager;
        }
    }
}




/******************************************************************************************************
 *        _________
 *       /        /|        _____________________________________________ 
 *      /________/ |        | 1- DATA ACCESS - VERİ ERİŞİM KATMANI      |
 *      |       |  |  <-->  |    Veriye erişmek için kullanılan         |
 *      |       |  |        |    katmandır.     SQL                     |
 *      |   DB  | /         |___________________________________________|
 *      |_______|/                          |
 *                                          /
 * veriye erişmek için çeşitli teknikler vardır. (x, y, z)
 * Soyutlama teknikleri ile düzen oluşturulur. (interface, class, abstract)
 * 
 * SOLID 
 * Farklı katmanlar oluşturup, farklı katmanlara yazma olayı PnP (Plag and Play) Tak ve Çalıştır
 *                        / 
 *      _________________|_________________________________ 
 *      | 2- Business - İş Katmanı(Kodları)              |
 *      |    İş kurallarının yazıldığı kodların olduğu   |
 *      |    bölümdür.                                   |
 *      |________________________________________________|    
 *                          |
 *      ____________________|______________________________ 
 *      | 3- API  - Servis Katmanı(Kodları)              |
 *      |    Restful Mimarisi (Format : JSON)            |
 *      |                                                |
 *      |________________________________________________| 
 *            /                 |               \
 *           /                  |                \
 *      ____/________     ______|________    _____\_________  
 *      |           |    |             |     |             |    
 *      | ANDROID   |    |   IOS       |     |UI / ASP.NET |
 *      |___________|    |_____________|     |_____________|
 *      
 *      
 ***************************************************************************************/
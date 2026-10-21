namespace c__adv_ass2;

internal class Program
{

     //  List<Product> : نوع القيمه اللي الميثود هترجعها وهي قائمه منتجات
    static List<Product> SearchProducts(
    List<Product> products,
    Func<Product, bool> filter)  // func -> delegate 
    {
        List<Product> result = new List<Product>();

        foreach (Product p in products)  // يلف عل كل منتج فالقايمه بتاعه المنتجات
        {
            if (filter(p))  // لو الفلتر اتحقق
            {
                result.Add(p);
            }
        }

        return result;
    }



   



    






    static void Main(string[] args)
    {


        // <Product> : Product من Object كل عنصر في القائمة لازم يكون
        List<Product> catalog = new()   
        {

            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }


        };


        // Func<Product, bool> 
        List<Product> electronics = SearchProducts( catalog , p => p.Category == "Electronics" );

        Console.WriteLine("--- Electronics ---");

        foreach (Product p in electronics)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
        Console.WriteLine();

        //-------------------------------------------------------------------------------------------------

        Console.WriteLine("--- Under 50 ---");

        List<Product> cheapProducts = SearchProducts( catalog , p => p.Price < 50);

        foreach (Product p in cheapProducts)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
        Console.WriteLine();

        //-------------------------------------------------------------------------------------------------

        Console.WriteLine("--- In Stock ---");

        List<Product> availableProducts = SearchProducts(catalog , p => p.Stock > 0);

        foreach (Product p in availableProducts)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
        Console.WriteLine();

        //-------------------------------------------------------------------------------------------------

        Console.WriteLine("--- Clothing Under $100 ---");

        List<Product> cheapClothing = SearchProducts(catalog , p => p.Category == "Clothing" && p.Price < 100);

        foreach (Product p in cheapClothing)
        {
            Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
        }
        Console.WriteLine();
        Console.WriteLine("------------------------------------");

        //-------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

        
















    }
}

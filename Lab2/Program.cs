using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        private static bool run = true;
        static void Main(string[] args) {

            while (run)
            {
                DisplayCategories();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "addc":
                        AddCategory();
                        break;
                    case "showc":
                        DisplayCategories();
                        break;
                    default:
                        Console.WriteLine("Nieznana komenda.");
                        break;
                }
                Console.ReadKey();
            }
           
          
   

        }
        private static void AddCategory()
        {
            Console.WriteLine("Podaj nazwę kategorii");
                 string new_name = Console.ReadLine();
                Category category = new Category { Name = new_name };

              ProdContext pc = new ProdContext();
                pc.Categories.Add(category);
                pc.SaveChanges();
        Console.ReadKey();

    }
    private static void DisplayCategories()
        {
            using (var db = new ProdContext())
            {
                var query = from cat in db.Categories
                            orderby cat.Name
                            select cat;

            /*    foreach (var c in query)
                {
                    Console.WriteLine("Nazwa kategorii", c.Name );
                }*/

            }
            Console.ReadKey();
        }


    }
}

namespace DZ_CS_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ex1();
            //Ex2();
            Ex3();
            
        }
        static void Ex1()
        {
            Magazine obj1 = new("Forbs", "+38099999999", "For Forbs",
                                        1979, "email@post.com", 44);

            Magazine obj2 = new("WSJ", "+38088888888", "For WSJ",
                                        1900, "email@post.com", 44);

            Console.WriteLine(obj1.ToString());
            Console.WriteLine();

            Console.WriteLine(obj2.ToString());
            Console.WriteLine();

            Console.WriteLine($"obj1  < obj2\t\t{obj1 < obj2}");
            Console.WriteLine($"obj1  > obj2\t\t{obj1 > obj2}");
            Console.WriteLine($"obj1 == obj2\t\t{obj1 == obj2}");
            Console.WriteLine($"obj1 != obj2\t\t{obj1 != obj2}");
            Console.WriteLine();

            Console.WriteLine($"obj2.Equals(obj1)\t{obj2.Equals(obj1)}");
            Console.WriteLine();

            Console.WriteLine($"Obj1.WorkersAmount:\t\t{obj1.WorkersAmount}");
            Console.WriteLine($"Obj1.WorkersAmount operator+:\t{obj1 + 10}");
            Console.WriteLine();
            Console.WriteLine($"Obj2.WorkersAmount:\t\t{obj2.WorkersAmount}");
            Console.WriteLine($"Obj2.WorkersAmount operator-:\t{obj2 - 10}");
            Console.WriteLine();
        }

        static void Ex2()
        {
            Shop obj3 = new("Zara", "+38099999999", "For Zara",
                                 "Odesa", "email@post.com", 155);

            Shop obj4 = new("WSJ", "+38088888888", "For WSJ",
                                 "Kyiv", "email@post.com", 180);

            Console.WriteLine(obj3.ToString());
            Console.WriteLine();

            Console.WriteLine(obj4.ToString());
            Console.WriteLine();

            Console.WriteLine($"obj1  < obj2\t\t{obj3 < obj4}");
            Console.WriteLine($"obj1  > obj2\t\t{obj3 > obj4}");
            Console.WriteLine($"obj1 == obj2\t\t{obj3 == obj4}");
            Console.WriteLine($"obj1 != obj2\t\t{obj3 != obj4}");
            Console.WriteLine();

            Console.WriteLine($"obj2.Equals(obj1)\t{obj4.Equals(obj3)}");
            Console.WriteLine();

            Console.WriteLine($"Obj1.WorkersAmount:\t\t{obj3.Area}");
            Console.WriteLine($"Obj1.WorkersAmount operator+:\t{obj3 + 10}");
            Console.WriteLine();
            Console.WriteLine($"Obj2.WorkersAmount:\t\t{obj4.Area}");
            Console.WriteLine($"Obj2.WorkersAmount operator-:\t{obj4 - 10}");
        }
        static void Ex3()
        {
            Library library = new();
            foreach (var item in library.books)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            library.AddBook();
            library.DeleteBook("Taras Shevchenko");
            for (int i = 0; i < library.books.Count; i++)
            {
                Console.WriteLine(library.books[i].ToString());
            }
            Console.WriteLine();
            try
            {
                library.books[12] = new Book();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
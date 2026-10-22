namespace CSharp_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Answer Question 1

            Book book = new Book
            {
                Title = "C# Basics",
                Pages = 300
            };

            object obj = book;
            Console.WriteLine(obj);



            // Answer Question 2

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());




            // Answer Question 3

            int pages = 464;

            Console.WriteLine(pages);



            // Answer Question 4

            try
            {
                int zero = 0;
                int result = 10 / zero;

                Console.WriteLine(result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            finally
            {
                Console.WriteLine("Done");
            }



            // Answer Question 5

            int bookPages = 300;

            double doublePages = bookPages;

            Console.WriteLine(doublePages);



            // Answer Question 6

            double price = 49.99;

            int intPrice = (int)price;

            Console.WriteLine(intPrice);



            // Answer Question 7

            string pagesText = "464";

            int convertedPages = Convert.ToInt32(pagesText);

            Console.WriteLine(convertedPages);




        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}

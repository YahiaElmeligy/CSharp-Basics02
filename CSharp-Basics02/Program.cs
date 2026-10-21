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

        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
    }
}

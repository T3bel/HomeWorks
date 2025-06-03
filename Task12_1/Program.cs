using System.Text;

namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books1 = new[]
            {
                new Book<string, int>("Записки охотника", "Тургенев", year:1847, code:"F-0001"),
                new Book<string, int>("Молчание Ягнят", "Томас Харрис", year:1988, code:"F-0002"),
                new Book<string, int>("Библия C# 5-е издание", "Михаил Фленов", year:2022, code:"F-1234")
            };

            var books2 = new[]
            {
                new Book<int, string>("Записки охотника", "Тургенев", year:"1847 год", code:1),
                new Book < int, string > ("Молчание Ягнят", "Томас Харрис", year : "1988 год", code : 42),
                new Book < int, string > ("Библия C# 5-е издание", "Михаил Фленов", year : "2022 год", code : 3)
            };

            var code1 = "F-1234";
            var code2 = 42;

            Console.WriteLine($"Книга с кодом {code1}: {FindBook<string, int>(books1, code1).ToString()}");
            Console.WriteLine($"Книга с кодом {code2}: {FindBook<int, string>(books2, code2).ToString()}");
            Console.ReadKey();
        }
        public static Book<T, U>? FindBook<T, U>(Book<T, U>[] books, T code) => books.FirstOrDefault(s => s.Code.Equals(code));
        //{
        //    foreach (var book in books)
        //        if (book.Code.Equals(code)) 
        //            return book;

        //    return null;
        //}
    }
    public class Book<T, U>
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public T Code { get; set; }
        public U PublicationYear { get; set; }

        public Book(string title, string author, T code, U year)
        {
            Title = title;
            Author = author;
            PublicationYear = year;
            Code = code;
        }
        public override string ToString() => $" Код: {Code} ({typeof(T)}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U)})";

    }
}

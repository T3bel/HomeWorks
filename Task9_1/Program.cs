using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task9_1
{
    internal class Program
    {
        static Dictionary<int, Book> _dictWithBook = new Dictionary<int, Book>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в нашу библиотеку!");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Сейчас в нашей библиоткеке {_dictWithBook.Count} книг");
                Console.WriteLine("\nКакое действие желаете выполнить?");
                Console.WriteLine("1 - Добавить книгу");
                Console.WriteLine("2 - Найти книгу");
                Console.WriteLine("3 - Ознакомиться со списком книг");
                Console.WriteLine("4 - Покинуть библиотеку");
                Console.Write("Ваш выбор (1-4): ");

                try
                {
                    int operation = int.TryParse(Console.ReadLine(), out int operInt) ? operInt : 0;
                    Console.WriteLine("-----------------------------------");
                    switch (operation)
                    {
                        case 1:
                            AddBook();
                            break;
                        case 2:
                            FindBook();
                            break;
                        case 3:
                            WriteAllBooks();
                            break;
                        case 4:
                            return;
                        default:
                            throw new InvalidOperationException("Неверный код операции!");
                    }
                    Console.Clear();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }


        static void AddBook()
        {
            Console.Write("Введите название книги: ");
            var bookName = Console.ReadLine();

            Console.Write("Введите автора книги: ");
            var bookAuthor = Console.ReadLine();

            Console.Write("Введите год издания: ");
            var bookYear = Console.ReadLine();

            Console.Write("Введите количество страниц: ");
            var bookPages = Console.ReadLine();

            _dictWithBook.Add(_dictWithBook.Count + 1, new Book(bookName, bookAuthor, bookYear, bookPages));
            Console.WriteLine($"Ваша книга была добавлена в библиотеку под индексом {_dictWithBook.Count}");
            Console.ReadKey();

        }

        static void FindBook()
        {
            //inKt bookID;
            Console.WriteLine("Введите код книги");
            var bookID = int.TryParse(Console.ReadLine(), out int bookIDint) ? bookIDint : throw new FormatException("Неверный код книги");
            if (!_dictWithBook.Keys.Contains(bookIDint)) throw new Exception($"Ключ {bookID} отсутствует в словаре!");
            Console.WriteLine($"Ваша книга: {_dictWithBook[bookID].GetInfo()}");
            Console.ReadKey();
        }

        static void WriteAllBooks()
        {
            if (_dictWithBook.Count == 0)
            {
                Console.WriteLine("Милорд, Ваша библиотека пуста!");
                return;
            }

            Console.WriteLine("Все книги в библиотеке: ");
            foreach (var key in _dictWithBook.Keys)
            {
                Console.WriteLine($"{key} --> {_dictWithBook[key].GetInfo()}");
            }
            Console.ReadKey();
        }
    }
    class Book
    {
        private string _title;

        private string _author;

        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, string year, string pages)
        {
            _title = title;
            _author = author;
            Year = ValidateYear(year);
            Pages = ValidatePages(pages);

        }

        private int ValidateYear(string yearValue)
        {
            int intYear;

            if (!int.TryParse(yearValue, out intYear)) throw new FormatException("Введите год, используя численное значение!");

            if (intYear > DateTime.Now.Year) throw new ArgumentException("Книги из будущего не принимаются в нашей библиотеке!");

            if (intYear < DateTime.MinValue.Year) throw new ArgumentException("Книги написанные до рождества Христова - ересь!");

            return intYear;
        }
        private int ValidatePages(string pagesValue)
        {
            int intPages;
            if (!int.TryParse(pagesValue, out intPages)) throw new FormatException("Введите кол-во страниц, используя численное значение!");

            if (intPages < 0) throw new ArgumentException("Количество страниц не может быть отрицательным");

            if (intPages > 10800) throw new ArgumentException("Вау, эта книга обогнала рекорд Гиннеса принадлежавший книге Шри Харичаритрамрут Сагар!\nТеперь наша библиотека прославится!");

            return intPages;
        }

        public string GetInfo()
        {
            var bookInfo = new StringBuilder();
            bookInfo.Append(_title).Append(", ");
            bookInfo.Append(_author).Append(", ");
            bookInfo.Append(Year).Append("г.").Append(", ");
            bookInfo.Append(Pages).Append(" стр.");

            return bookInfo.ToString();
        }
    }
}

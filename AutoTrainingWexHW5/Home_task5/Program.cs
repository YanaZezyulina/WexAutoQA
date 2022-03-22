using System;

namespace Home_task5
{
    class Program
    {
        //Task5 - создать класс Книга(в нем название (строка),
        //количество страниц (int), уникальный идентификатор (строка)..
        //Создайте массив книг (5 штук) проинициализируйте его различными 
        //объектами типа "Книга", и выведите информацию о всех книгах в массиве на экран
        static void Main(string[] args)
        {
            //Book book1 = new Book { BookTitle = "Idiot", PageCount = 640, UniqueIdentifier = "I" };
            //Book book2 = new Book { BookTitle = "Voina i Mir", PageCount = 768, UniqueIdentifier = "ViM" };
            //Book book3 = new Book { BookTitle = "Palata 6", PageCount = 236, UniqueIdentifier = "P6" };
            //Book book4 = new Book { BookTitle = "Jane Eyre", PageCount = 512, UniqueIdentifier = "JY" };
            //Book book5 = new Book { BookTitle = "Lady Audley's Secret", PageCount = 560, UniqueIdentifier = "LAS" };

            Book book1 = new Book("Idiot", 640, "I");
            Book book2 = new Book("Voina i Mir", 768, "ViM");
            Book book3 = new Book("Palata 6", 236,"P6");
            Book book4 = new Book("Jane Eyre", 512, "JY");
            Book book5 = new Book("Lady Audley's Secret", 560, "LAS");
            //book1.SetBook("Idiot", 640, "I");
            Book[] books = {book1, book2, book3, book4, book5};

            foreach (Book item in books)
            {
                Console.WriteLine(item.GetBookInfo());
            }
        }
    }
}

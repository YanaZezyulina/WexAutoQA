using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task5
{
    class Book
    {
        public string BookTitle { get; set; }
        public int PageCount { get; set; }
        public string UniqueIdentifier { get; set; }


        public Book(string bTitle, int pCount, string uIdentifier)
        {
            BookTitle = bTitle;
            PageCount = pCount;
            UniqueIdentifier = uIdentifier;
        }

        public string GetBookInfo() 
        {
            return String.Format("Book title: {0}, Count of pages: {1}, UniqueIdentifier: {2}",
                    BookTitle, PageCount, UniqueIdentifier);
        }
    }
}

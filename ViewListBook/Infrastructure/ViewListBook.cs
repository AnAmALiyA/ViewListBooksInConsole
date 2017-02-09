using System;
using System.Collections.Generic;

namespace ViewListBook
{
    public class ViewListBook
    {
        public void ShowListBook(List<Book> listBooks)
        {
            foreach (Book book in listBooks)
            {
                Console.WriteLine("{0} - {1}, {2} ст. - {3} г.", book.Author, book.NameBook, book.Pages, book.Date.Year);
            }

            Console.ReadKey();
        }
    }
}
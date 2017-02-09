using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewListBook
{
    public class BussinesLogicBooks
    {
        CreateListBook ListBook { get; set; }
        ViewListBook ViewListBook { get; set; }

        public BussinesLogicBooks()
        {
            ListBook = new CreateListBook();
            ViewListBook = new ViewListBook();
        }

        public void ShowListBook()
        {
            ViewListBook.ShowListBook(ListBook.ListBook);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewListBook
{
    public class CreateListBook
    {
        public List<Book> ListBook { get; set; }

        public CreateListBook()
        {
            ListBook = new List<Book>();
            FillTheList();
        }

        private void FillTheList()
        {
            ListBook.Add(new Book { NameBook = "\"CLR via C#. Программирование на платформе Microsoft .NET Framework 4.5 на языке C#\"", Author = "Рихтер Дж.", Date = new DateTime(2013, 1, 1), Pages = 896 });
            ListBook.Add(new Book { NameBook = "\"Язык программирования C#5.0 и платформа .NET 4.5\"", Author = "Эндрю Троелсен", Date = new DateTime(2015, 1, 1), Pages = 1534 });
            ListBook.Add(new Book { NameBook = "\"Примеры объектно-ориентированного проектирования Паттерны проектирования\"", Author = "Э. Гамма, Р. Хелм, Р. Джонсон, Д. Влиссидес", Date = new DateTime(2010, 1, 1), Pages = 368 });
            ListBook.Add(new Book { NameBook = "\"Design Patterns via C#. Приемы объектно -ориентированного проектирования\"", Author = "Шевчук А., Охрименко Д., Касьянов А.", Date = new DateTime(2015, 1, 1), Pages = 288 });
            ListBook.Add(new Book { NameBook = "\"SQL Справочник\"", Author = "К. Клайн, Д. Клайна и Б. Ханта", Date = new DateTime(2015, 10, 9), Pages = 119 });
            ListBook.Add(new Book { NameBook = "\"jQuery Учебник для начинающих\"", Author = "Антон Шевчук", Date = new DateTime(2013, 1, 1), Pages = 149 });
            ListBook.Add(new Book { NameBook = "\"JavaScript Подробное руководство\"", Author = "Дэвид Флэнаган", Date = new DateTime(2008, 1, 1), Pages = 982 });
            ListBook.Add(new Book { NameBook = "\"JavaScript для профессиональных веб - разработчиков\"", Author = "Николас Закас", Date = new DateTime(2015, 1, 1), Pages = 960 });
            ListBook.Add(new Book { NameBook = "\"HTML и CSS. Путь к совершенству.\"", Author = "Бен Хеник", Date = new DateTime(2011, 1, 1), Pages = 336 });
            ListBook.Add(new Book { NameBook = "\"ASP.NET MVC 4 с примерами на C# 5.0 для профессионалов\"", Author = "Адам Фримен", Date = new DateTime(2014, 1, 1), Pages = 666 });
        }        
    }
}

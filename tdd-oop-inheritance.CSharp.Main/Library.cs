using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {

        List<ReadingObject> readingObjects = new List<ReadingObject>();

        List<Article> articles = new List<Article>();
        List<Book> books = new List<Book>();
        List<Newspaper> newspapers = new List<Newspaper>();

        public List<ReadingObject> ReadingObjects { get { return readingObjects; } }

        public void AddToStock(ReadingObject readingObject)
        {
            this.readingObjects.Add(readingObject);
        }


        public string CheckInReadingObject(string title)
        {
            List<ReadingObject> filtered = this.readingObjects.Where(rObject => rObject.title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }


        public string CheckOutReadingObject(string title)
        {
            List<ReadingObject> filtered = this.readingObjects.Where(rObject => rObject.title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to create an object:
            //using the constructor the pass in parameters
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);


            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;


            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            //use this to change information
            //title would change from the lord of the rings to the hobbit
            book2.title = "The Hobbit";

            //book2.title = "Lord of the Rings";
            //book2.author = "Tolkein";
            //book2.pages = 700;


            Book book3 = new Book();

            



            Console.ReadLine();
        }
    }
}

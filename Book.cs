using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    class Book
    {   //class is just a blueprint for a program
        public string title;
        public string author;
        public int pages; 
        

               //constructor: a special method
        //you can use this to pass directly to a parameter
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }


        //constructor. a different way of using em:
        public Book() { }



    }
}

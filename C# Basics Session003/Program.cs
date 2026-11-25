using System.Runtime.InteropServices;
using System.Text;

namespace C__Basics_Session003
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////string title = "clean code";
            ////string upperTitle = title.ToUpper();

            ////Console.WriteLine(title.ToUpper());
            ////Console.WriteLine(upperTitle);

            ///*--------------------------------------------------*/

            ////string x = "Clean Code";
            ////string y = "Clean Code";

            ////Console.WriteLine(object.ReferenceEquals(x, y));
            ///*--------------------------------------------------*/

            ////StringBuilder sb = new StringBuilder("Book List");

            ////sb.Append(" - Updata");

            ////Console.WriteLine(sb);

            ///*--------------------------------------------------*/
            ////StringBuilder sb = new StringBuilder("Book List");

            ////sb.Append(" - Updata");
            ////sb.Replace("Book List", "Library");

            ////Console.WriteLine(sb);
            ///*--------------------------------------------------*/

            ////string title = "Clean Code";

            ////int pages = 464;

            ////Console.WriteLine("Book : " + title + " / "  + "Pages : " + pages);

            ///*--------------------------------------------------*/

            ////string title = "Clean Code";

            ////int pages = 464;

            ////Console.WriteLine($"Book : {title} / Pages : {pages} ");

            ///*--------------------------------------------------*/

            ////string title = "Clean Code";

            ////int pages = 464;

            ////Console.WriteLine("Book : {0} / Pages : {1} ", title , pages);

            ///*--------------------------------------------------*/

            ////int pages = 464;

            ////if (pages >= 300) Console.WriteLine("LongBook");
            ////else Console.WriteLine("ShortBook");

            ///*--------------------------------------------------*/
            ////int pages = 464;
            ////bool isAvailable = true;

            ////if (pages >= 300 && isAvailable) 
            ////Console.WriteLine("You can borrow this book");

            ///*--------------------------------------------------*/
            ////string title = "Refactoring";

            ////switch (title)
            ////{
            ////    case "Clean code":
            ////        Console.WriteLine("Great choice!");
            ////        break;
            ////    case "Refactoring":
            ////        Console.WriteLine("Nice pick!");
            ////        break;
            ////    default:
            ////        Console.WriteLine("Never heard of it");
            ////        break;
            ////}

            ///*--------------------------------------------------*/
            ////int pages = 464;

            ////string result = pages >= 300 ? "LongBook" : "ShortBook";

            ////Console.WriteLine(result);
            ///*--------------------------------------------------*/
            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////for (int i = 0; i < books.Length; i++)
            ////    Console.WriteLine($"{i}. {books[i]} ");

            ///*--------------------------------------------------*/

            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////int i = 0;

            ////while (i < books.Length)
            ////{
            ////    Console.WriteLine($"{i}. {books[i]} ");
            ////    i++;
            ////}            
            ///*--------------------------------------------------*/
            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////int i = 0;

            ////do
            ////{
            ////    Console.WriteLine($"Checking book is {i}");
            ////    i++;

            ////}
            ////while (i < books.Length);

            ///*--------------------------------------------------*/
            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////foreach(string Book in books)
            ////    Console.WriteLine(Book);

            ///*--------------------------------------------------*/
            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////for (int i = 0; i < books.Length; i++)
            ////{
            ////    if (books[i] == "Refactoring")
            ////    {
            ////        break;
            ////    }
            ////    Console.WriteLine(books[i]);
            ////}
            ///*--------------------------------------------------*/
            //// string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            ////for (int i = 0; i < books.Length; i++)
            ////{
            ////    if (books[i] == "The Pragmatic Programmer")
            ////    {
            ////        continue;
            ////    }
            ////    Console.WriteLine(books[i]);
            ////}
            ///*--------------------------------------------------*/

            ////string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            ////string[] books2 = { };

            ////PrintFirstBook(books2);
            ///*--------------------------------------------------*/

        }

        static void PrintFirstBook(string[] books)
        {

            for (int i = 0; i < books.Length; i++)
            {
                if (books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[i]);
            }
        }
    }
}



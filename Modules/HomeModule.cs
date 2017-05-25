using Nancy;
using BookList.Objects;
using System.Collections.Generic;

namespace BookList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

// Notes:
// POST["/SITEURL"] -> Post method from index.cshtml,
//    ["/SITEURL"] -> will need to loop thru @book.GetTitle, @book.GetAuth
// Book newBook -> object from Book.cs
// Book.GetAll() -> static method from Book.cs
// Code is adding user input into bookList
// return will send user to ["bookList.cshtml"]


      Post["/bookList"] = _ => {
        Book newBook = new Book(Request.Form["bookTitle"], Request.Form["bookAuthor"]);
        List<Book> bookList = Book.GetAll();
        return View["bookList.cshtml", bookList];
      };
    }
  }
}

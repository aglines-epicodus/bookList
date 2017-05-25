using System.Collections.Generic;

namespace BookList.Objects
{
  public class Book
  {
    private string _title;
    private string _author;
    private static List<Book> _instances = new List<Book> {};
    public Book(string title, string author)
    {
      _title = title;
      _author = author;
      _instances.Add(this);
    }
    public string GetTitle()
    {
      return _title;
    }

// SETTER methods are now above in Book static methods


    public string GetAuthor()
    {
      return _author;
    }

    public static List<Book> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Book Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}

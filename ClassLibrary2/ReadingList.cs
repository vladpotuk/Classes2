using System;
using System.Collections.Generic;

public class ReadingList
{
    private List<string> books = new List<string>();

    
    public void AddBook(string book)
    {
        books.Add(book);
    }

    
    public void RemoveBook(string book)
    {
        books.Remove(book);
    }

    
    public bool ContainsBook(string book)
    {
        return books.Contains(book);
    }

    
    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }
}

namespace ObjectOriented.Classes.ClassesPractice;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Name = name;
        Books = [];
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        var mantainBooks = new List<Book>();

        foreach (var item in Books)
        {
            if (item.Title != book.Title || item.Author != book.Author)
            {
                mantainBooks.Add(item);
            }
        }

        Books = mantainBooks;
    }

    public List<Book> SearchBooks(string searchString)
    {
        var searchList = new List<Book>();

        foreach (var item in Books)
        {
            if (item.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase)
                || item.Author.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            {
                searchList.Add(item);
            }
        }

        return searchList;
    }
}

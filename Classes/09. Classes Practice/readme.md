# Classes Practice

Wizards are having a hard time keeping track of all the books in their library. They need your help to create a library system that will allow them to add, remove, and search for books.

Magical incantations to find books have unfortunately not been invented yet.

## Assignment

You've been tasked with writing the code for the wizard library. Complete the `Library` and `Book` classes listed below.

1. [ ] Create the `Book` Class:
   1. [ ] Create the `Book(string title, string author)` constructor
   2. [ ] Set `Title` and `Author` to the values of the parameters.
2. [ ] Create the `Library` Class:
   1. [ ] Create the `Library(string name)` constructor
   2. [ ] Initialize a `Name` property to the value of the `name` parameter.
   3. [ ] Create a `Books` property initialized to an empty list.
3. [ ] Add the `AddBook(Book book)` method:
   1. [ ] Add `book`, the given `Book` instance, to the library's `Books` list by [adding](https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1.add) it to the end of the list.
4. [ ] Add the `RemoveBook(Book book)` method:
   1. [ ] Create a new, empty list to hold the books you want to keep.
   2. [ ] Loop through every book in the library's books list.
   3. [ ] If the book's `Title` or `Author` do not match the one you want to remove, add it to the new list.
   4. [ ] After checking all the books, replace the library's books list with the new list.
5. [ ] Add the `SearchBooks(string searchString)` method:
   1. [ ] For every book in the library check if the `searchString` is contained in the `Title` *or* `Author` field (case-\_in_sensitive).
   2. [ ] Return a list of all books that match the search string, ordered in the same order as they were added to the library.

After a book is removed, it should no longer be returned in the search results.

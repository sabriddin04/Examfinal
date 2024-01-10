interface ILibrary
{
    void AddBook(Book book);
    void DisplayBooks(Book book);
    void UpdateBook(Book book);
    void DeleteBook(int id);
    Book SearchByTitle(string title);
   List<Book> SearchByAuthor(string author);
}
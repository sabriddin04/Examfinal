using System.Linq.Expressions;

class Library
{
    List<Book>books=new List<Book>();

   public void AddBook(Book book){
    books.Add(book);
   }
   public void DisplayBooks(){
    foreach (var item in books)
    {
        System.Console.WriteLine($"ID:{item.Id}");
        System.Console.WriteLine($"Author:{item.Author}");
        System.Console.WriteLine($"Title:{item.Title}");
    }

   }
   public void UpdateBook(Book book){
    foreach (var item in books)
    {
        if(item.Id==book.Id){
            item.Author=book.Author;
            item.Title=book.Title;
        }
    }
   } 
   public void DeleteBook(int id){
   var book= books.FirstOrDefault(x=>x.Id==id);

       books.Remove(book);

   }
   

   
   public Book SearchByTitle(string title){
    var book= books.FirstOrDefault(x=>x.Title==title);
    return book;

   }

   public List<Book> SearchByAuthor(string author){
    List<Book>newlist= new List<Book>();

     newlist=books.FindAll(x=>x.Author==author);
     return newlist;

   }
}




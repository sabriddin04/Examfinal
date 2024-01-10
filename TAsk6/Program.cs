var book1=new Book();
book1.Id=1;
book1.Author="turaev";
book1.Title="math";
var book2=new Book();
book2.Id=2;
book2.Author="Pushkin";
book2.Title="russian";
var book3=new Book();
book3.Id=3;
book3.Author="Pushkin";
book3.Title="sher";
var book4=new Book();
book4.Id=4;
book4.Author="Firdavsi";
book4.Title="Shohnoma";
var bibl1=new Library();
bibl1.AddBook(book1);
bibl1.AddBook(book2);
bibl1.AddBook(book3);
bibl1.AddBook(book4);
bibl1.DisplayBooks();
System.Console.WriteLine("-----------------------------------");
bibl1.DeleteBook(1);
bibl1.DisplayBooks();
System.Console.WriteLine("-----------------------------------");
List<Book>newlist=bibl1.SearchByAuthor("Pushkin");
foreach (var item in newlist)
{
   
        System.Console.WriteLine($"ID:{item.Id}");
        System.Console.WriteLine($"Author:{item.Author}");
        System.Console.WriteLine($"Title:{item.Title}");

}
System.Console.WriteLine("-----------------------------------");
Book sabr=bibl1.SearchByTitle("sher");
System.Console.WriteLine(sabr.Id);
System.Console.WriteLine(sabr.Author);
System.Console.WriteLine(sabr.Title);



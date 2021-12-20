using LibraryConsoleApp;
//********__1__********
//string[] namesArr = new string[] {"marcos","ermias","lior","haim","eden","matan","eliyahu"};
//var filteredNamesList = from name in namesArr
//                         where name.ToLower()[0] == 'e'
//                         select name;

//foreach (string item in filteredNamesList)
//{
//Console.WriteLine(item);
//}
//********__1__********



//********__2__********
//Random randomNum = new Random();
//int[] tenAgesArr = new int[10];

//for (int i = 0; i < tenAgesArr.Length; i++)
//{
//    tenAgesArr[i] = randomNum.Next(0,40);
//}

//var filteredAgesList = from age in tenAgesArr
//                       where age > 20
//                       select age;

//foreach (var age in filteredAgesList)
//{
//    Console.WriteLine(age);
//}
//********__2__********

//********__3__Create a class__********

//********__4__********
List<Book> books = new List<Book>();
Random random = new Random();

books.Add(new Book("Bible", "God", random.Next(0,500)));
books.Add(new Book("Harry Poter", "haim", random.Next(0,500)));
books.Add(new Book("Game of thrones", "God", random.Next(0,500)));
books.Add(new Book("The Lord of the Rings", "God", random.Next(0,500)));
books.Add(new Book("Don Quixote", "lior", random.Next(0,500)));
books.Add(new Book("A Tale of Two Cities", "aschalow", random.Next(0,500)));
//********__4__********



//********__5__********
//var filteredBooks200PagesList = from book in books
//                                where book.pages > 200
//                                select book;
//********__5__********



//********__6__********
//var filteredBooks4LettersList = from book in books
//                                where book.author.Length >= 4
//                                select book;
//********__6__********



//********__7__********
//Book firstShortBook = books.Find(book => book.pages < 150);
//********__7__********



//********__8__********
//var filteredEndWithY = from book in books
//                       where book.title.ToLower()[book.title.Length - 1] == 'y'
//                       select book;
//********__8__********

//********__9__Change 3 authers__********

//********__10__********
var filteredList = from book in books
                   group book by book.author;

//foreach (var group in filteredList)
//{
//    Console.WriteLine($"group name: {group.Key}");
//    foreach (Book item in group)
//    {
//        item.PrintBook();
//    }
//    Console.WriteLine();
//}


foreach (var group in filteredList)
{
    Console.WriteLine($"group name: {group.Key}");
    foreach (Book book in group)
    {
        Console.WriteLine($"book title: {book.title}");
    }
    Console.WriteLine();
}
//********__10__********
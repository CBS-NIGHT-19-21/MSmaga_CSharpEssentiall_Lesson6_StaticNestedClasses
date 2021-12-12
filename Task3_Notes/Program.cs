namespace Task3_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3
            //Используя Visual Studio, создайте проект по шаблону Console Application. 
            //Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который 
            //позволит сохранять заметки читателя. 
            #endregion

            // Initialization of attributes for Book object.
            string title = "Alice's Adventures in Wonderland";

            string text = "ALICE was beginning to get very tired of sitting by  her sister  on the  bank,  and of  having " +
                          "nothing  to  do:  once or  twice she  had peeped  into the  book her  sister was  reading,  " +
                          "but it  had no pictures or conversations in it, and what is the use of a book,” thought Alice, " +
                          "“ without pictures or conversations ?”";

            // Instance class Book.
            Book book = new Book(title, text);

            // Show its attributes
            book.Show();

            // Makes notes using serial number of position in text.
            book.MakeNote(6);
            book.MakeNote(13);
            book.MakeNote(19);
            book.MakeNote(39);
            book.MakeNote(46);
            book.MakeNote(59);

            // Show Book attributes.
            book.Show();

            // Show Book Marks.
            book.Notes.ShowMarks(5);
            book.Notes.ShowMark(3);

            // Delay.
            Console.ReadLine();
        }
    }
}


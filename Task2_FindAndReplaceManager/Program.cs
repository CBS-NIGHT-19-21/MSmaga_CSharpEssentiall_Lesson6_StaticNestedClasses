namespace Task2_FindAndReplaceManager
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 2
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Требуется: 
            // Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для
            // поиска по книге из примера урока 005_Delegation. При вызове этого метода, производится 
            // последовательный поиск строки в книге.
            #endregion

            // Initialization of original text.
            string originalText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt " +
                            "ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                            "laboris nisi ut aliquip ex ea commodo consequat.  aute irure dolor in reprehenderit " +
                            "in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat " +
                            "cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine($"Text:\n{originalText}\n");

            // Initialization of the text to find.
            string textToFind = "in";

            Console.WriteLine($"Text to find: {textToFind}\n");

            // Use static extension method to find text.
            Console.WriteLine("Show positions in the text:");

            originalText.FindNext(textToFind);

            // Delay.
            Console.ReadKey();
        }
    }
}





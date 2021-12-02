// Declare static class FindAndReplace Manager as an extension class for string variable.
static class FindAndReplaceManager
{
    // Declare static method FindNext for extension class function for string variable.
    static public void FindNext(this string text, string str)
    {
        char[] charText = text.ToCharArray();
        char[] charStr = str.ToCharArray();


        for (int i = 0; i < charText.Length - str.Length; i++)

        {   // Find first char coincidence in string as char array
            if (charText[i] == charStr[0])
            {
                bool coincidence = true;

                // Find rest char coincidence in string as char array
                for (int j = 1; j < charStr.Length; j++)
                {
                    coincidence = coincidence && (charText[i + j] == charStr[j]);
                }

                if (coincidence) Console.WriteLine($"Position = {i};");

            }
        }
    }
}
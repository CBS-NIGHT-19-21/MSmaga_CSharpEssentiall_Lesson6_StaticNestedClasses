// Declaration and initialization of Extension Class for realization extended methods.
static class ExtensionClass
{
    // this - to refer to the object for which the extended method was realization.
    /// <summary>
    /// Shows elements of the array
    /// </summary>
    /// <param name="array"></param>
    public static void Show(this int[] array)
    {
        Console.Write("\nArray = {");

        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }

        Console.Write("};");
    }
    // this - to refer to the object for which the extended method was realization.
    /// <summary>
    /// Sorts One-Dimensional array by Increment by Bubble sort
    /// If passing didn't have any replaces - empty passing
    /// </summary>
    /// <param name="array"></param>
    public static void SortBubbleInc(this int[] array)
    {

        int numPass = array.Length - 1;
        int adressLastBuble = array.Length - 1;
        int replace = 1;

        for (int i = 0; i < numPass; i++)
        {
            if (replace != 0)
            {
                replace = 0;

                for (int j = 0; j < adressLastBuble; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int buffer = array[j + 1];

                        array[j + 1] = array[j];

                        array[j] = buffer;

                        replace++;
                    }
                }
            }
        }
    }

    // this - to refer to the object for which the extended method was realization.
    /// <summary>
    /// Sorts and shows array
    /// </summary>
    /// <param name="array"></param>
    public static void SortInc(this int[] array)
    {
        SortBubbleInc(array);

        Show(array);
    }
}

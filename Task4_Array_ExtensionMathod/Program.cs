#region Задание 4
//Используя Visual Studio, создайте проект по шаблону Console Application. 
//Требуется: создать расширяющий метод для целочисленного массива, который сортирует элементы 
//массива по возрастанию.
#endregion

// Declaration and initialization of an array.
int[] array = new[] { 2, 4, 6, 1, 2, 56, 34, 2, 95, 4, 2, 4, 13, 197, 1, 45, 2, 3, 59, 32, 44, 65, 45, 13, 19 };

// Call extention method Show().
array.Show();

// Call extention method SortInc().
array.SortInc();

// Delay.
Console.ReadLine();

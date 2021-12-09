namespace Task_Additional_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Требуется: 
            // Создать статический класс Calculator, с методами для выполнения основных арифметических
            // операций. 
            // Написать программу, которая выводит на экран основные арифметические операции. 
            #endregion

            //Variables declaration
            double operand1, operand2, result1, result2, result3, result4;

            //Input data
            Console.Write("Please, insert first operand:");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please, insert second operand:");
            operand2 = Convert.ToDouble(Console.ReadLine());

            //Call static methods from static class Calculator
            result1 = Calculator.Add(operand1, operand2);
            result2 = Calculator.Sub(operand1, operand2);
            result3 = Calculator.Mul(operand1, operand2);
            result4 = Calculator.Div(operand1, operand2);

            //Output data
            Console.WriteLine($"Add = {result1}");
            Console.WriteLine($"Sub = {result2}");
            Console.WriteLine($"Mul = {result3}");
            Console.WriteLine($"Div = {result4:F2}");

            //Call static method as Extention
            result1 = operand1.Add(operand2);
            result2 = operand1.Sub(operand2);
            result3 = operand1.Mul(operand2);
            result4 = operand1.Div(operand2);

            //Output data
            Console.WriteLine($"Add = {result1}");
            Console.WriteLine($"Sub = {result2}");
            Console.WriteLine($"Mul = {result3}");
            Console.WriteLine($"Div = {result4:F2}");

            Console.ReadLine();

        }
    }
}


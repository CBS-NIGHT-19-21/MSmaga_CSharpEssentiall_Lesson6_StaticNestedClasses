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
            double operand1, operand2, addResult, subResult, mulResult, divResult;

            //Input data
            Console.Write("Please, insert first operand:");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please, insert second operand:");
            operand2 = Convert.ToDouble(Console.ReadLine());

            //Call static methods from static class Calculator
            addResult = Calculator.Add(operand1, operand2);
            subResult = Calculator.Sub(operand1, operand2);
            mulResult = Calculator.Mul(operand1, operand2);
            divResult = Calculator.Div(operand1, operand2);

            //Output data
            Console.WriteLine($"Add = {addResult}");
            Console.WriteLine($"Sub = {subResult}");
            Console.WriteLine($"Mul = {mulResult}");
            Console.WriteLine($"Div = {divResult:F2}");

            //Call static method as Extention
            addResult = operand1.Add(operand2);
            subResult = operand1.Sub(operand2);
            mulResult = operand1.Mul(operand2);
            divResult = operand1.Div(operand2);

            //Output data
            Console.WriteLine($"Add = {addResult}");
            Console.WriteLine($"Sub = {subResult}");
            Console.WriteLine($"Mul = {mulResult}");
            Console.WriteLine($"Div = {divResult:F2}");

            Console.ReadLine();

        }
    }
}


using System;

class FormattingExcersice
{
    static void Main(string[] args)
    {
        // Read the input from console
        int firstNumber = int.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        // Convert the number to binary
        string binary = Convert.ToString(firstNumber, 2).PadLeft(10,'0');

        // Output
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:F3}|", firstNumber, binary, secondNumber, thirdNumber);
    }
}

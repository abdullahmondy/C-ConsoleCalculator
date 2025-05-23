using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;

public class CalculatorInterface : CalculatorLogic
{
    double num1;
    double num2;
    double result;
    public enum OperationSymbol
    {
        Add = '+',
        Subtract = '-',
        Multiply = '*',
        Divide = '/'
    }

    OperationSymbol op;


 
    public void Input()
    {
        Console.WriteLine("/nEnter the first number...");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter the second number...");
        string input2 = Console.ReadLine();
        Console.WriteLine("Enter the operation [ + , - , * , /]...");
        char input3 = Console.ReadLine()[0];

         num1 = double.Parse(input1);
         num2 = int.Parse(input2);

        switch (input3)
        {
            case '+':
                op = OperationSymbol.Add;
                break;
            case '-':
                op = OperationSymbol.Subtract;
                break;
            case '*':
                op = OperationSymbol.Multiply;
                break;
            case '/':
                op = OperationSymbol.Divide;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;  // Exit the method if input is invalid
        }
    }

    public void Output()
    {
        switch (op)
        {
            case OperationSymbol.Add:
                result = Sum(num1, num2);
                Console.WriteLine($"{num1} {(char)OperationSymbol.Add} {num2} = {result}");
                break;
            case OperationSymbol.Subtract:
                result = Sub(num1, num2);
                Console.WriteLine($"{num1} {(char)OperationSymbol.Subtract} {num2} = {result}");
                break;
            case OperationSymbol.Multiply:
                result = Multibly(num1, num2);
                Console.WriteLine($"{num1} {(char)OperationSymbol.Multiply} {num2} = {result}");
                break;
            case OperationSymbol.Divide:
                result = Divide(num1, num2);
                Console.WriteLine($"{num1} {(char)OperationSymbol.Divide} {num2} = {result}");
                break;
        }
    }

    public void ShowhistoryScreen()
    {
        if(history.Count > 0)
        {
            foreach (var item in history)
            {
                foreach(var i in item)
                {
                    Console.WriteLine($"[{i.Key}] {i.Value}");
                }
            }
        }
        else
        {
            Console.WriteLine("There's no history");
        }
    }

    public void ShowOperationScreen()
    {
        Input();
        Output();
    }

    public void menu()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("\t\t Calculator Menu");
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("\n1) Operation" + "\n2) History");

        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {
            if(number == 1)
            {
                ShowOperationScreen();
            }
            else if(number == 2) 
            {
                ShowhistoryScreen();
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    public void StartCalculator()
    {
        string Answer = "Yes";

        while (Answer == "Yes" || Answer == "yes")
        {
            menu();
            Console.WriteLine("Do you want to go back to the main menu? Yes / No");
            Answer = Console.ReadLine();
        }
    }
}
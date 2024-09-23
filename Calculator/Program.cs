
CalculatorApp();

/* void CalculatorApp()
{

    // This line outputs a message asking the user to input their first number.
    Console.WriteLine("Type in the first number followed by the Enter key:");

    // This integer variable stores the value the user inputs
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    // This line outputs a message asking the user to input their first number.
    Console.WriteLine("\nType in the second number followed by the Enter key:");

    // This integer variable stores the second number.
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    // This integer variable stores the sum of the first number and the second number.
    int result = firstNumber + secondNumber;

    // This line outputs the content of the result variable.
    Console.WriteLine("\nThe addition of " + firstNumber + " and " + secondNumber + " is:\n" + result);
    Console.ReadKey();

} */

void CalculatorApp()
{

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int menuSelection = 0;

    Console.WriteLine("Type in the first number and press enter:");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nType in the second number and press enter:");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nPlease select which operation you would like to perform:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");
    menuSelection = Convert.ToInt32(Console.ReadLine());

    if (menuSelection == 1)
    {

        result = firstNumber + secondNumber;
        Console.WriteLine("Adding " + firstNumber + " to " + secondNumber + " equals:\n" + result);

    }
    else if (menuSelection == 2)
    {

        result = firstNumber - secondNumber;
        Console.WriteLine("Subtracting " + firstNumber + " from " + secondNumber + " equals:\n" + result);

    }
    else if (menuSelection == 3)
    {

        result = firstNumber / secondNumber;
        Console.WriteLine("Diving " + firstNumber + " by " + secondNumber + " equals:\n" + result);

    }
    else if (menuSelection == 4)
    {

        result = firstNumber * secondNumber;
        Console.WriteLine("Multiplying " + firstNumber + " by " + secondNumber + " equals:\n" + result);

    } else
    {

        Console.WriteLine("Please select a valid number between 1 and 4!");

    }

    

}


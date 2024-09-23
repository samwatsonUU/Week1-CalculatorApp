
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
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//perform the calculation
int result = firstNumber + secondNumber;

//output answer to console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);

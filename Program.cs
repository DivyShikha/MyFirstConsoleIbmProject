// See https://aka.ms/new-console-template for more information


using MyFirstConsoleIbmProject;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to C#.Net Programming Fundamentals");

////Variable Declaration
//Console.WriteLine("Enter name:");

////demo();
//CalculatorDemo();

//Loops loop = new Loops();
//loop.ForEachExample();
//loop.WhileLoopExample();
//loop.ForEachExample();
//loop.DoWHileExample();  

Student student = new Student();
Console.WriteLine($"The name of the student is : {student.studentName}");    

student.CalculateAverage();
student.PrintTotalMarks();
student.PrintAverageMarks();

static void demo()
{
    int number = 10;
    string greeting = "Hello, C#!";
    Console.WriteLine($"Number : {number} and Greeting: {greeting}");
}


int number1 = Convert.ToInt32(Console.Read());

static void CalculatorDemo()
{
    Calculator calculator = new Calculator();

    Console.WriteLine("Select operation:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.Write("Enter your choice (1-4): ");
    int choice = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = 0;
    bool validOperation = true;

    switch (choice)
    {
        case 1:
            result = calculator.Add(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
            break;
        case 2:
            result = calculator.Subtract(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
            break;
        case 3:
            result = calculator.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
            break;
        case 4:
            if (secondNumber != 0)
            {
                result = calculator.Divide(firstNumber, secondNumber);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;
        default:
            validOperation = false;
            Console.WriteLine("Invalid choice.");
            break;
    } 
}
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

//Student student = new Student();
//Console.WriteLine($"The name of the student is : {student.studentName}");    

//student.CalculateAverage();
//student.PrintTotalMarks();
//student.PrintAverageMarks();

//JaggedArray jaggedArray = new JaggedArray();

//EmployeeSalaryBreakdown();

DisplayProductDetails();


static void demo()
{
    int number = 10;
    string greeting = "Hello, C#!";
    Console.WriteLine($"Number : {number} and Greeting: {greeting}");
}



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

static void EmployeeSalaryBreakdown()
{
    EmployeeDetails employee = new EmployeeDetails();

    employee.captureEmployeeDetails();
    Console.WriteLine(employee.calculateAnnualSalary()); 


}
static void DisplayProductDetails()
{
    bool exit = false;
    List<Product> productList = new List<Product>();

    Console.WriteLine("----------PRODUCT MANAGEMENT SYSTEM----------");

    while (!exit)
    {
        Console.WriteLine("\n-----MAIN MENU-----");
        Console.WriteLine("1. Add a new product");
        Console.WriteLine("2. View product details");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":

                Console.Write("Enter Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Enter Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Console.Write("Enter Product quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product newProduct = new Product(prodName, prodPrice, prodQuantity);
                productList.Add(newProduct);

                Console.WriteLine("Product added successfully!");
                break;

            case  "2":
                if (productList.Count == 0)
                {
                    Console.WriteLine("No products available.");
                }
                else
                {
                    Console.WriteLine("\n--- Product List ---");
                    int index = 1;
                    foreach (Product p in productList)
                    {
                        Console.WriteLine($"\nProduct {index++}:");
                        Console.WriteLine($"Name: {p.ProductName}");
                        Console.WriteLine($"Price: {p.ProductPrice:C}");
                        Console.WriteLine($"Quantity: {p.ProductQuantity}");
                        Console.WriteLine($"Total Value: {p.CalculateToTalPrice():C}");
                    }
                }
                break;

            case "3":
                exit = true;
                Console.WriteLine("Exiting program. Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
        

    }

    
}

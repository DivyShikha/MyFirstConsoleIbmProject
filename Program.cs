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

//DisplayProductDetails();

//DisplayPersonDetails();
//DisplayVehicleDetails();
//DisplayConsultingEmployeeAllDetails();
TechnoprenureDemo();


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

static void DisplayPersonDetails()
{
    Person person1 = new Person("A101", "Anushree", "Ranchi", 43);
    Person person2 = new Person("A102", "Sanya", "Pune", 56);
    Console.WriteLine(person2.ToString());
    person2.name = "Aakash";
    Console.WriteLine(person2.ToString());
    Console.WriteLine(person1.ToString());
    person1.UpdatePersonInfo("Kusum", "Assam", 32);
    Console.WriteLine(person1.ToString());
}
static void DisplayConsultingEmployeeAllDetails()
{
    ConsultingEmployee consultingEmployee = new ConsultingEmployee();

    Console.Write("Enter government ID: ");
    consultingEmployee.ID = Console.ReadLine();
    Console.Write("Enter name: ");
    consultingEmployee.name = Console.ReadLine();
    Console.Write("Enter city: ");
    consultingEmployee.city = Console.ReadLine();
    Console.Write("Enter age: ");
    consultingEmployee.age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter employee id: ");
    consultingEmployee.EmployeeId = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter role: ");
    consultingEmployee.Role = Console.ReadLine();
    Console.Write("Enter email: ");
    consultingEmployee.Email = Console.ReadLine();
    Console.Write("Enter salary: ");
    consultingEmployee.Salary = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter consulting firm: ");
    consultingEmployee.ConsultingFirm = Console.ReadLine();
    Console.Write("Enter consulting duration: ");
    consultingEmployee.ConsultingDuration = Convert.ToInt32(Console.ReadLine());

    
    consultingEmployee.DisplayPersonInfo();
    consultingEmployee.DisplayEmployeeDetails();
    consultingEmployee.DisplayConsultingEmployeeDetails();

}
static void DisplayVehicleDetails()
{
    

    var C = new Car();
    ElectricCar tesla = new ElectricCar(
             battery: 75,
             range: 400,
             doors: 4,
             company: "Tesla Inc.",
             type: "Sedan",
             make: "Tesla",
             model: "Model 3",
             year: 2024
         );

    // This automatically calls ToString()
    Console.WriteLine(tesla);

    

    // You can also call DescribeVehicle (inherited & overridden)
    Console.WriteLine(tesla.DescribeVehicle());
}
static void TechnoprenureDemo()
{
    TechnoPrenure technoPrenure = new TechnoPrenure();
    Console.WriteLine("Please enter your ID:");
    technoPrenure.ID = Console.ReadLine();
    Console.WriteLine("Please enter your Name:");
    technoPrenure.name = Console.ReadLine();
    Console.WriteLine("Please enter your City:");
    technoPrenure.city = Console.ReadLine();
    Console.WriteLine("Please enter your Age:");
    technoPrenure.age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Entrepreneur ID:");
    technoPrenure.EntroprenurId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your Business Name:");
    technoPrenure.BusinessName = Console.ReadLine();
    Console.WriteLine("Please enter your Business Type:");
    technoPrenure.BusinessType = Console.ReadLine();
    Console.WriteLine("Please enter your Investment Amount:");
    technoPrenure.InvestmentAmount = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please enter your Years in Business:");
    technoPrenure.YearsInBusiness = Convert.ToInt32(Console.ReadLine());

    technoPrenure.DisplayEntroprenurDetails();
    Console.WriteLine($"Entrepreneur Info: {technoPrenure.GetEntroprenurInfo()}");
}


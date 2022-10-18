using System;
using OOPS;
using OOPS.Oops;

class Program
{
    static void Main(string[] args)
    {
        //var intNum = 100;
        //var doubleNum = 100d;
        //var floatNum = 100f;
        //var decimalNum = 100m;
        //Console.WriteLine($"Datatype of intNum is: {intNum.GetType().ToString()}");
        //Console.WriteLine($"Datatype of doubleNum is: {doubleNum.GetType().ToString()}");
        //Console.WriteLine($"Datatype of floatNum is: {floatNum.GetType().ToString()}");
        //Console.WriteLine($"Datatype of decimalNum is: {decimalNum.GetType().ToString()}");

        //GST();
        //var currency = 43892320d;
        // string str = "100";
        //decimal decCurrency = (decimal)currency;
        //int num = Convert.ToInt32(str);

        // Rectangle r1 = new Rectangle(20, 5);
        //float area = r1.CalculateArea();
        //Console.WriteLine($"Area of R1 with length" + $"{r1.Length} and breadth {r1.Breadth} is" + $"{area}");

        //Square sq1 = new Square(25);
        // area = sq1.CalculateArea();
        //Console.WriteLine($"Area of sq1 with length" + $"{sq1.Length} and breadth {sq1.Breadth} is" + $"{area}");

        //ToDo myToDo = new ToDo() {  Name = "Coding", StartDate = DateTime.Now.AddDays(-15), EndDate = DateTime.Now.AddDays(+15), Iscompleted =false };

        //myToDo.Create(0);
        //myToDo.Name = "Angular training";
        //myToDo.StartDate = DateTime.Now.AddDays(-10);
        //myToDo.EndDate = DateTime.Now.AddDays(-4);
        //myToDo.Iscompleted = true;

        //myToDo.Create(1);
        //myToDo.ViewToDos();
        //myToDo.ViewToDos("Coding");

        //Base class = new DerivedClass()
        //Parent Meena = new Child();
        //Parents.ChooseCareer();
        //Meena.ChooseCareer();

        //Base=new Derived
        Shape sh = new Circle() { Radius = 5 };
        sh.Draw();
    }

    private static void GST()
    {
        //Console.WriteLine("Enter the food: ");
        //var name = Console.ReadLine();
        //Console.WriteLine("Enter the value: ");
        //var value = Console.ReadLine();
        //double value;
        //double gst;
        //double e = 1.18;
        //double total = value * e;
        //gst = total - value;
        //Console.WriteLine($"Total: {total} value: {value} GST: {gst}");
    }

    private static void UseArithmeticOperations()
    {
        try
        {
            Calculate(1888, 43123, "Add");
            Calculate(7763, 46937294, "exponent");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Something has gone wrong" + $"Please contact- suppost with this error code:{ex.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    private static void PrintAndRead()
    {
        //Console.WriteLine("Hello, World!");
        //Console.WriteLine("This code help is a KOOL feature :-)");
        //Console.WriteLine("Enter Something:");
        //var input = Console.ReadLine();

        //Print the entered value
        //Console.WriteLine(input);
        //Console.WriteLine("The user value entered is : " + input);
        //Console.WriteLine("Improvised Concatenation: {0}", input);
        //Console.WriteLine($"Latest technique of concatenation: {input}");


        Console.WriteLine("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your place: ");
        var place = Console.ReadLine();
        Console.WriteLine("Enter your hobbies: ");
        var hobbies = Console.ReadLine();

        Console.WriteLine($"The person's name is {name}. {name}'s place is {place}. Hobbies are {hobbies}");


    }


    public static void Calculate(int num1, int num2, string operationType)
    {
        //Take 2 numbers from user
        //Take which operation to perform from user
        //Use switch case and write the code for all arithmetic operations
        switch (operationType)
        {
            case "Add":
                Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                break;
            case "Subtract":
                Console.WriteLine($"The difference of {num1} and {num2} is {num1 - num2}");
                break;
            case "Multiply":
                Console.WriteLine($"The product of {num1} and {num2} is {num1 * num2}");
                break;
            case "Divide":
                Console.WriteLine($"The quotient of {num1} and {num2} is {num1 / num2}");
                break;
            default:
                throw new Exception("Invalid Operation Type!");


        }
    }

}

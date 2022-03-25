//First Varible
string calculater;

//Varible to all
string option;
double res;
bool run = true;

//Varible to only calculator
double number1; 
double number2;

//Varible to Area Calculator
double height;
double width;
double baseline;
double radius;
double pi = Math.PI;

while (run)
{ 
    Console.WriteLine("What do you want to calculate?: Calculator/c or Area Calculator/a");
    calculater = Console.ReadLine();

    if (calculater == "c")
    {
        Console.WriteLine("This is the calculater, do you want to (+, -, *, /)? ");
        option = Console.ReadLine();

        Console.WriteLine("Write the first number you want to calculate with: ");
        number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Write the second number you want to calculate with: ");
        number2 = double.Parse(Console.ReadLine());

        switch (option)
        {
            case "+":
                res = number1 + number2;
                Console.WriteLine("The result is: " + res);
                break;

            case "-":
                res = number1 - number2;
                Console.WriteLine("The result is: " + res);
                break;

            case "*":
                res = number1 * number2;
                Console.WriteLine("The result is: " + res);
                break;

            case "/":
                res = number1 / number2;
                Console.WriteLine("The result is: " + res);
                break;

            default:
                Console.WriteLine("Invalid input");
                break;
        }
    } 
    else if (calculater == "a")
    {

        Console.WriteLine("This is a calculater for area calculating: (Rectangle/r, Circle/c or Triangle/t)");
        option = Console.ReadLine();

        switch (option)
        { 
            case "r":
                Console.WriteLine("What is the height?");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the width?");
                width = double.Parse(Console.ReadLine());

                double AreaRect = getAreaRect(height, width);

                Console.WriteLine("The result is: " + AreaRect);
                break;

            case "c":
                Console.WriteLine("What is The radius?");
                radius = double.Parse(Console.ReadLine());

                double AreaCircle = getAreaCircle(radius);

                Console.WriteLine("The result is: " + AreaCircle);
                break;

            case "t":
                Console.WriteLine("What is the height?");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("What is the baseline?");
                baseline = double.Parse(Console.ReadLine());

                double AreaTriangle = getAreaTriangle(height, baseline);

                Console.WriteLine("The result is: " + AreaTriangle);
                break;

            default:
                Console.WriteLine("Invalid input");
                break;

    
        }

    }

    Console.WriteLine("Do you want to try again?");
    string answer = Console.ReadLine();

    if (answer == "y")
    {
        run = true;
    } else
    { 
        run = false;
        Console.WriteLine("Thanks for trying");
    }
}
//Functions

//Rectangle function
double getAreaRect(double num1, double num2)
{
    return num1 * num2;
}

//Circle function
double getAreaCircle(double num1)
{
    return pi * num1 * num1;
}

//Triangle function
double getAreaTriangle(double num1, double num2)
{
    return num1 * num2 / 2;
}
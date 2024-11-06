// Q1 : Write a program that enters the diameter of the circle from the keyboard and prints the circumference of the circle : 

Console.WriteLine("Enter the diameter of the circle : ");
double Diameter = Convert.ToDouble (Console.ReadLine());

double CircumferenceOfTheCircle = Math.PI * Diameter;

Console.WriteLine($"Circumference of the Circle = {CircumferenceOfTheCircle}");

// Q2 : Write a program that inputs time and distance from the keyboard and print the speed in meters per hour and kilometers per hour : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter the Distance in Meters : ");
double Distance = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the time in hours : ");
double Time = Convert.ToDouble(Console.ReadLine());

double SpeedMetersPerHour = Distance / Time;
double SpeedKilometersPerHour = SpeedMetersPerHour / 1000;

Console.WriteLine($"\nSpeed = {SpeedMetersPerHour} meters per hour");
Console.WriteLine($"Speed = {SpeedKilometersPerHour} kilometers per hour");

// Q3 : What are the differences between Post Increment and Pre-Increment operators?

/*
In Pre-Increment, the operator sign (++) comes before the variable. 
It increments the value of a variable before assigning it to another variable. 
In Post-Increment, the operator sign (++) comes after the variable. 
It assigns the value of a variable to another variable and then increments its value.
 */

// Q4 : Use Math.Round to round a double number to the nearest integer : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter any number u need : ");
double Number = Convert.ToDouble(Console.ReadLine());

double RoundNumber = Math.Round(Number);
double FloorNumber = Math.Floor(Number);
double CeilingNumber = Math.Ceiling(Number);

Console.WriteLine($"The Number After Rounded : {RoundNumber}"); 
Console.WriteLine($"The Number After Floor : {FloorNumber}"); 
Console.WriteLine($"The Number After Ceiling : {CeilingNumber}");

// Q5 : Use Math.Pow to calculate the result of baseNumberraised to the power of exponent : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter any number u need : ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number u need : ");
int Number2 = Convert.ToInt32(Console.ReadLine());

double PowNumber = Math.Pow(Number1, Number2);
Console.WriteLine($"\nNumber1 raised to the power of Number2 = {PowNumber}");

// Q6 : Write a program to check whether a year is a leap or not : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter any year u need : ");
int Year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Year % 4 == 0 ? $"{Year} is leap." : $"{Year} is NOT leap.");

// Q7 : Write program to Check whether an alphabet is lowercase or uppercase : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter any char u need : ");
char Character = Convert.ToChar(Console.ReadLine());

Console.WriteLine(char.IsUpper(Character) ? $"{Character} is an uppercase letter." : ($"{Character} is a lowercase letter."));

// And we can solve it by ASCII code : 

Console.WriteLine("\nASCII : ");

if (Character >= 'A' && Character <= 'Z')
{
    Console.WriteLine($"{Character} is an uppercase letter.");
}
else if (Character >= 'a' && Character <= 'z')
{
    Console.WriteLine($"{Character} is a lowercase letter.");
}
else
{
    Console.WriteLine("The input is not a valid alphabet.");
}

// Q8 : Write a program to create a simple calculator (*/+-) using switch statement : 

Console.WriteLine("\n\n");

Console.WriteLine("Choose the calculation you want : \n1. Add \n2. Sub \n3. Mul \n4. Dev");
int Choose = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number : ");
double FirstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number : ");
double SecondNumber = Convert.ToDouble(Console.ReadLine());

double Result;

Console.WriteLine("\n");

switch (Choose)
{
    case 1:
        Result = FirstNumber + SecondNumber;
        Console.WriteLine($"{FirstNumber} + {SecondNumber} = {Result}");
        break;

    case 2:
        Result = FirstNumber - SecondNumber;
        Console.WriteLine($"{FirstNumber} - {SecondNumber} = {Result}");
        break;

    case 3:
        Result = FirstNumber * SecondNumber;
        Console.WriteLine($"{FirstNumber} * {SecondNumber} = {Result}");
        break;

    case 4:
        Result = FirstNumber / SecondNumber;
        Console.WriteLine($"{FirstNumber} / {SecondNumber} = {Result}");
        break;
}

// Q9 : Write a program to take 3 numbers from the keyboard and find the maximum number using ternary operator : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter Number1 : ");
int Number3 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number2 : ");
int Number4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Number3 : ");
int Number5 = Convert.ToInt32(Console.ReadLine());

int MaxNumber = (Number3 > Number4) ? (Number3 > Number5 ? Number3 : Number5) : (Number4 > Number5 ? Number4 : Number5);

Console.WriteLine($"\nThe maximum number is {MaxNumber}");

// Q10 : Write a program to takes a number from the keyboard and check if  the number is odd or even using Ternary operator : 

Console.WriteLine("\n\n");

Console.WriteLine("Enter any number u need : ");
int Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");

Console.WriteLine(Num % 2 == 0 ? $"{Num} is Even" : $"{Num} is Odd"); 
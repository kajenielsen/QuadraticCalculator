// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

float a = 1.0F; //Setting coefficients as 1 to begin
float b = 1.0F;
float c = 1.0F;
float xOneF = 1.0F;
float xTwoF = 1.0F; //We had to initialize these beforehand or it caused the code to crash.

// Insert user input lines here.

Console.WriteLine("The quadratic is written in the form of ax^2+bx+c. By defining the values of a, b, and c, we can find the x intercepts, or zeros of the function.");
while (true)
{
    try
    {
        Console.WriteLine("Please type the value for 'a', then hit enter.");
        string? textA = Console.ReadLine();
        a = Convert.ToSingle(textA);
        break;
    }
    catch
    {
        Console.WriteLine("Please enter a valid value for a.");
    }
}

while (true)
{
    try
    {
        Console.WriteLine("Please type the value for 'b', then hit enter.");
        string? textB = Console.ReadLine();
        b = Convert.ToSingle(textB);
        break;
    }
    catch
    {
        Console.WriteLine("Please enter a valid value for b.");
    }
}
while (true)
{
    try
    {
        Console.WriteLine("Please type the value for 'c', then hit enter.");
        string? textC = Console.ReadLine();
        c = Convert.ToSingle(textC);
        break;
    }
    catch
    {
        Console.WriteLine("Please enter a valid value for c.");
    }
}


// Math formula
double squareStrip = (Math.Pow(b, 2)) - (4 * a * c); // squareStrip = b^2-4ac
double xOne = ((b * -1) + Math.Sqrt(squareStrip)) / 2 * a; // Quadratic formula with addition
xOneF = Convert.ToSingle(xOne);
double xTwo = ((b * -1) - Math.Sqrt(squareStrip)) / 2 * a; // Quadratic formula with subtraction
xTwoF = Convert.ToSingle(xTwo);


//Output lines
if (float.IsNaN(xOneF))
{
    Console.WriteLine("The function does not contain any zeroes.");
}
else
{
    Console.WriteLine($"The function contains zeros at approximately ({xOneF},0) and ({xTwoF},0)."); //This is the only line of code that it ever executes despite what xOneF and xTwoF are equal to. :'(
}

/* Debugging
Console.WriteLine(xOneF);
Console.WriteLine(xTwoF);
float Test = float.NaN;
Console.WriteLine(Test);
*/

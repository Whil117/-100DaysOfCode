class Program
{
    string color = "red";
    static void printYourName(string myName , string myLastName, int age )
    {
        Console.WriteLine($"Hello {myName} {myLastName} {age}");
    }
    static int sumNumbers(int numberOne, int numberTwo)
    {
        return numberOne + numberTwo;
    }

    static int myIntNumber(int x, int y)
    {
        return x + y;
    }
    static double myDoubleNumber(double x , double y)
    {
        return x + y;
    }
    static void Main()
    {

        Program myObj = new Program();
        Console.WriteLine(myObj.color);
    }
}
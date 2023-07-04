Console.WriteLine("Enter your name:");

string myName = Console.ReadLine() ?? "default value";

Console.WriteLine("Enter your age:");

string getAge = Console.ReadLine() ?? string.Empty;

bool validateAge = String.IsNullOrEmpty(getAge);

int year = DateTime.Now.Year;

if (validateAge)
{
 Console.WriteLine("Please Write your age in number");
return;
}

int myAge = Convert.ToInt32(year) - Convert.ToInt32(getAge);


Console.WriteLine($"Your name has: {myName.Length} characters");

Console.WriteLine($"Your name is {myName} and you were bornin {myAge}");

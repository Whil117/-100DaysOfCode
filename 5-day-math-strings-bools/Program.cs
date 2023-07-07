
/////Math Round, Max, Min Sqrt
double putNumber = 23.1;
double putNumberTwo = 23.2;


Console.WriteLine($" The square is:{Math.Sqrt(putNumber)} ");
Console.WriteLine($"The first number was rounded: {Math.Round(putNumber)}");
Console.WriteLine($"The number {Math.Max(putNumber, putNumberTwo)} is major thant {Math.Min(putNumber, putNumberTwo)}");

////String Methods

Console.WriteLine("----------------------------------------");
string myName = "Ivan Garcia";

string txt = "Ivan Garcia is \"Fullstack\" Jr";

Console.WriteLine(txt);
Console.WriteLine($"{myName.ToUpper()} UPPERCASE");
Console.WriteLine($"{myName.ToLower()} LOWERCASE");
Console.WriteLine();

Console.WriteLine($"Your name has ${myName.Length} characters");


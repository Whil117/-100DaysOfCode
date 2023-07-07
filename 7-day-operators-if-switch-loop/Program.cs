//C# Conditions and If Statements

int numb1 = 10;
int numb2 = 12;

if (numb1 < numb2)
{
    Console.WriteLine("number 1 is minor than number 2");
}

if (numb1 + 8 > numb2 + 5)
{
    Console.WriteLine("Number One is major than number 2");
}

if (numb1 +2 == numb2)
{
    Console.WriteLine("Both Numbers are equal");
}

if (numb1 + 3 != numb2)
{
    Console.WriteLine("Both Numbers are not equal");
}


Console.WriteLine((numb1 > numb2) ? "Number one ternary operator" : "Number two ternary operator");

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

string[] techs = { "React", "Javascript", "Vuejs" };

Console.WriteLine(techs[0]);


foreach (string item in techs)
{
    Console.WriteLine($"{item} is a web technology");
}

techs[2] = "Svelte Kit";

Array.Sort(techs);

Console.WriteLine(techs.Length);
Console.WriteLine(techs[2]);
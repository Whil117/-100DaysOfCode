int myNumb = 1223;
long myNum = 15000000000L;
float f1 = 35e3F;
double d1 = 12E4D;
const string numberInText = "123";


Console.WriteLine(f1);
Console.WriteLine(d1);
Console.WriteLine(myNum);

Console.WriteLine(myNumb);
Console.WriteLine(Convert.ToString(myNumb) + " " + "Hello");

Console.WriteLine(Convert.ToBoolean(myNum) + " " +"My Booolean");

Console.WriteLine(Convert.ToString(numberInText) + " " +"My Convert Num to String");
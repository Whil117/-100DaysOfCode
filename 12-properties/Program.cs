using System.ComponentModel;
using System.Security.Cryptography;
using System.Xml.Linq;

class Person
{
    private int age;

    public int ChangeAge
    {
        get { return age; }   
        set {

            if (value >= 18)
            {
                age = value;
            } else
            {
                age = 18;
            }
        }  
    }
}



class Car
{
    private string status = "Your car is locked.";
    private const string CorrectKey = "mykey";
   
    public string PutYourKeyCar(string key)
    {
        if (key == CorrectKey)
        {
            status = "Your car is open";
            return "Correct password";
        }else
        {
            return "Wrong password";
        }
    }
    public string StatusCar
    { get { return status; } }

}
class Program
{
    static void Main()
    {
        Car car = new Car();

        string password =   car.PutYourKeyCar("123123");
        Console.WriteLine(password);
        Console.WriteLine(car.StatusCar);
    }
}


//public accessible for all classes
//private only it's accesible within the same class
//protected accessible with the same class or inherited from that class.
// intertal only assembly but not other assmebly

class User
{
    private string name = "ivan";
    public string lastName = "Garcia";
     
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        Console.WriteLine(user.lastName);
        Console.WriteLine(user.name);
    }
}
using System.Drawing;
 class Car
{
    private string brand = "Tesla";
    private int year = 2023;
    private string color = "black";
    public string ChangeColor
    {
        get { return color; }
        set { color = value; }
    }
    public string GetColor()
    {
        return color;
    }
    public string GetBrand()
    {
        return brand;
    }
    public int GetYear()
    {
        return year;
    }
}

class CompetitionCars:Car
{
    private string datenow = DateTime.Now.ToString();
    public string GetNowDate()
    {
        return datenow;
    }

}
class Program
{
    static void Main()
    {
        CompetitionCars competition = new CompetitionCars();
        competition.ChangeColor = "red";
        Console.Write(competition.GetColor());
        Console.WriteLine(competition.GetNowDate());
    }
}
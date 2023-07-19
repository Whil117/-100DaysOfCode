
class Car
{
    private string brand = "Tesla";
    private int model = 2020;
    private int price = 0;
    public Car(string myBrand, int myModel)
    {
        brand = myBrand; // Set the initial value for model
        model = myModel;
    }
    public void addPriceCar (int newPrice)
    {
        price = newPrice;
    }
    public string getCarBrand()
    {
        return brand;
    }
    public int getCarModel()
    {
        return model;
    }

}
class Program
{
    static void Main()
    {
        Car car = new Car("Volvo", 2017);
        Console.WriteLine(car.getCarBrand());
        Console.WriteLine(car.getCarModel());
     
    }
}
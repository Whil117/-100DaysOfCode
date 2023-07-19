class Food
{
    public string name = "Hamburger";
    public string ingredient = "Sauce";
    public int price = 10;
    public string destination = "New york";
    public void  addPrice(int foodPrice)
    {
        price = foodPrice;
    }
    public void addIngredient (string newIngredient)
    {
       ingredient = newIngredient;
        addPrice(newIngredient.Length);

    }
}



class Program
{
    static void Main(String[] args)
    {
        Food food = new Food();
        Console.WriteLine(food.destination);
        food.addIngredient("Ketchup");
        Console.WriteLine(food.ingredient); //// Ketchup
        Console.WriteLine(food.name); // Hamburger
        Console.WriteLine(food.price); // ?????
    }
}


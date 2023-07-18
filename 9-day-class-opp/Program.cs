class Food
{
    string name = "Hamburger";
    string ingredient = "Sauce";
    int price = 10;
    private string destination = "New york";


    private void  addPrice(int foodPrice)
    {
        price = foodPrice;

    }
    private void addIngredient (string newIngredient)
    {
       ingredient = newIngredient;
        addPrice(newIngredient.Length);

    }
    static void Main(string[] args)
    {
        Food food  = new Food();
        Console.WriteLine(food.destination);
        food.addIngredient("Ketchup");
        Console.WriteLine(food.ingredient); //// Ketchup
        Console.WriteLine(food.name); // Hamburger
        Console.WriteLine(food.price); // ?????
    }
}


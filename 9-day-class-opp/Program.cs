class Food
{
    string name = "Hamburger";
    string ingredient = "Sauce";
    int price = 10;

    public void  addPrice(int foodPrice)
    {
        price = foodPrice;

    }
    public void addIngredient (string newIngredient)
    {
       ingredient = newIngredient;
        addPrice(newIngredient.Length);

    }
    static void Main(string[] args)
    {
        Food food  = new Food();
        food.addIngredient("Ketchup");
        Console.WriteLine(food.ingredient); //// Ketchup
        Console.WriteLine(food.name); // Hamburger
        Console.WriteLine(food.price); // ?????
    }
}
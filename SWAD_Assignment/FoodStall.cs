public class FoodStall
{
    public string Name;
    public List<FoodItem> foodItems;

    public FoodStall(string name)
    {
        Name = name;
        foodItems = new();
    }

    public FoodStall(string name, List<FoodItem> foodItems)
    {
        Name = name;
        this.foodItems = foodItems;
    }

    public string addFoodItem(FoodItem fi)
    {
        foodItems.Add(fi);
        return fi.Name;
    }

    public List<FoodItem> getMenu()
    {
        return foodItems;
    }

    public FoodItem selectFoodItem(int index)
    {
        return foodItems[index - 1];
    }

    public override string ToString()
    {
        return Name;
    }

    public void deleteItem(FoodItem fi)
    {
        foodItems.Remove(fi);
    }
}
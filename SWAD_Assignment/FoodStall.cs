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

    public string addMenuItem(FoodItem fi)
    {
        foodItems.Add(fi);
        return fi.Name;
    }

    public List<FoodItem> getAllFoodItems()
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

    public string deleteItem(FoodItem fi)
    {
        string itemName = fi.Name;
        foodItems.Remove(fi);
        return itemName;
    }
}
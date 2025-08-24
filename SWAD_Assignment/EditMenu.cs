public class EditMenu
{
    public FoodItem selectFoodItem(FoodStall fs, int index)
    {
        return fs.selectFoodItem(index);
    }

    public bool toggleAvailability(FoodItem fi)
    {
        return fi.toggleAvailability();
    }

    public string updateName(FoodItem fi, string name)
    {
        return fi.setName(name);
    }

    public double updatePrice(FoodItem fi, double price)
    {
        return fi.setPrice(price);
    }

    public string updateDescription(FoodItem fi, string desc)
    {
        return fi.setDescription(desc);
    }

    public string updatePhoto(FoodItem fi, string url)
    {
        return fi.setImageUrl(url);
    }

    public void deleteItem(FoodStall fs, FoodItem fi)
    {
        fs.deleteItem(fi);
    }

    public string addFoodItem(FoodStall fs, FoodItem fi)
    {
        return fs.addFoodItem(fi);
    }

    public List<FoodItem> getMenu(FoodStall fs)
    {
        return fs.getMenu();
    }
 }
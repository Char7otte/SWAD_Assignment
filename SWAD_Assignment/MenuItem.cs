public class FoodItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public bool available { get; set; }

    public FoodItem(string name, double price, string description, string imgUrl)
    {
        Name = name;
        Price = price;
        Description = description;
        ImageUrl = imgUrl;
        available = true;
    }

    public override string ToString()
    {
        return $"{Name} (${Price:0.00}) {(!available ? "(UNAVAILABLE)" : "")}\nImage:{ImageUrl}\n{Description}";
    }

    public string setName(string newName)
    {
        Name = newName;
        return Name;
    }

    public double setPrice(double newPrice)
    {
        Price = newPrice;
        return Price;
    }

    public string setDescription(string newDescription)
    {
        Description = newDescription;
        return Description;
    }

    public string setImageUrl(string newImageUrl)
    {
        ImageUrl = newImageUrl;
        return ImageUrl;
    }

    public bool toggleAvailability()
    {
        available = !available;
        return available;
    }
}

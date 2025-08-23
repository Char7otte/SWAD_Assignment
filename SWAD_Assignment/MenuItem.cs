public class MenuItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public bool disabled { get; set; }

    public MenuItem(string name, double price, string description, string imgUrl)
    {
        Name = name;
        Price = price;
        Description = description;
        ImageUrl = imgUrl;
        disabled = false;
    }

    public override string ToString()
    {
        return $"{Name} (${Price:0.00}) {(disabled ? "(UNAVAILABLE)" : "")}\nImage:{ImageUrl}\n{Description}";
    }

    public void setName(string newName)
    {
        Console.Write($"{Name} has been changed to ");
        Name = newName;
        Console.Write($"{newName}.");
        Console.WriteLine();
    }

    public void setPrice(double newPrice)
    {
        Price = newPrice;
        Console.WriteLine($"Price updated to ${newPrice}");
        Console.ReadLine();
    }

    public void setDescription(string newDescription)
    {
        Description = newDescription;
        Console.WriteLine($"Description updated to: {newDescription}");
        Console.ReadLine();
    }

    public void setImageUrl(string newImageUrl)
    {
        ImageUrl = newImageUrl;
        Console.WriteLine($"Image URL updated to: {newImageUrl}");
        Console.ReadLine();
    }

    public void toggleDisabled()
    {
        disabled = !disabled;
        Console.WriteLine($"{Name} is now {(disabled ? "hidden" : "available for order")}.");
        Console.ReadLine();
    }

    public void updateItemInformation()
    {
        Console.WriteLine("What would you like to update?");
        Console.WriteLine("1. Name");
        Console.WriteLine("2. Price");
        Console.WriteLine("3. Description");
        Console.WriteLine("4. Product photo");
        Console.WriteLine("0. Cancel");
        var input = Console.ReadLine();

        if (input == "0") return;
        else if (input == "1") updateName();
        else if (input == "2") updatePrice();
        else if (input == "3") updateDescription();
        else if (input == "4") updatePhoto();
    }

    public void updateName()
    {
        Console.WriteLine("Enter new name: ");
        string name = Console.ReadLine();
        setName(name);
    }

    public void updatePrice()
    {
        Console.WriteLine("Enter new price: ");
        double price = double.Parse(Console.ReadLine());
        setPrice(price);
    }

    public void updateDescription()
    {
        Console.WriteLine("Enter new description: ");
        string description = Console.ReadLine();
        setDescription(description);
    }

        public void updatePhoto()
    {
        Console.WriteLine("Upload new product photo:  ");
        string imgUrl = Console.ReadLine();
        setImageUrl(imgUrl);
    }
}

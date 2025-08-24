FoodItem margheritaPizza = new FoodItem("Margherita Pizza", 14.99, "Classic pizza with tomato sauce, fresh mozzarella, and basil.", "images/margherita.jpg");
margheritaPizza.available = false;
FoodItem caesarSalad = new FoodItem("Caesar Salad", 9.50, "Crisp romaine lettuce with parmesan, croutons, and our homemade Caesar dressing.", "images/caesar.jpg");
FoodItem chocolateLavaCake = new FoodItem("Chocolate Lava Cake", 8.25, "Warm chocolate cake with a molten center, served with vanilla ice cream.", "images/lava-cake.jpg");

FoodStall foodStall1 = new("The Gilded Fork", new List<FoodItem>([margheritaPizza, caesarSalad, chocolateLavaCake]));
Staff foodStaff1 = new Staff("foodStaff@gmail.com", "123", "Jerry Tan", foodStall1);

while (true)
{
    Console.WriteLine($"Welcome, {foodStaff1} of {foodStaff1.foodStall}");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Update menu");
    Console.WriteLine("0. Exit");
    var input = Console.ReadLine();

    if (input == "0") Environment.Exit(0);
    else if (input == "1") updateMenu(foodStaff1);
    else Console.WriteLine("Please enter a valid option!");
}

void updateMenu(Staff fs)
{
    
    while (true)
    {
        Console.WriteLine();
        fs.foodStall.displayMenu();
        Console.WriteLine("1. Modify existing item");
        Console.WriteLine("2. Add new item");
        Console.WriteLine("0. Return");
        var input = Console.ReadLine();

        if (input == "0") break;
        else if (input == "1") fs.foodStall.modifyItem();
        else if (input == "2") fs.foodStall.createNewItem();
        else Console.WriteLine("Please enter a valid option!");
    }
}

public void modifyItem()
{
    Console.WriteLine();
    Console.WriteLine("What item do you want to modify?");
    var input = Console.ReadLine();
    try
    {
        FoodItem menuItem = selectMenuItem(int.Parse(input));
        Console.WriteLine();
        Console.WriteLine(menuItem);
        Console.WriteLine();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Update item information");
        Console.WriteLine("2. Change availability");
        Console.WriteLine("3. Delete item");
        Console.WriteLine("0. Cancel");

        input = Console.ReadLine();
        if (input == "0") return;
        else if (input == "1") menuItem.updateItemInformation();
        else if (input == "2") menuItem.toggleAvailability();
        else if (input == "3")
        {
            string itemName = menuItem.Name;
            foodItems.Remove(menuItem);
            Console.WriteLine($"{itemName} has been deleted.");
            Console.ReadLine();
        }
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("index out of range");
        Console.WriteLine("Invalid option.");
    }
    catch
    {
        Console.WriteLine("Invalid option.");
    }
}

MenuItem margheritaPizza = new MenuItem("Margherita Pizza", 14.99, "Classic pizza with tomato sauce, fresh mozzarella, and basil.", "images/margherita.jpg");
margheritaPizza.disabled = true;
MenuItem caesarSalad = new MenuItem("Caesar Salad", 9.50, "Crisp romaine lettuce with parmesan, croutons, and our homemade Caesar dressing.", "images/caesar.jpg");
MenuItem chocolateLavaCake = new MenuItem("Chocolate Lava Cake", 8.25, "Warm chocolate cake with a molten center, served with vanilla ice cream.", "images/lava-cake.jpg");

Restaurant restaurant1 = new("The Gilded Fork", new List<MenuItem>([margheritaPizza, caesarSalad, chocolateLavaCake]));

FoodStaff foodStaff1 = new("Jerry Tan", restaurant1);

while (true)
{
    Console.WriteLine($"Welcome, {foodStaff1} of {foodStaff1.restaurant}");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Update menu");
    Console.WriteLine("0. Exit");
    var input = Console.ReadLine();

    if (input == "0") Environment.Exit(0);
    else if (input == "1") updateMenu(foodStaff1);
    else Console.WriteLine("Please enter a valid option!");
}

void updateMenu(FoodStaff fs)
{
    while (true)
    {
        fs.restaurant.displayMenu();
        Console.WriteLine("1. Modify existing item");
        Console.WriteLine("2. Add new item");
        Console.WriteLine("0. Return");
        var input = Console.ReadLine();

        if (input == "0") break;
        else if (input == "1") fs.restaurant.modifyItem();
        else if (input == "2") fs.restaurant.createNewItem();
        else Console.WriteLine("Please enter a valid option!");
    }
}

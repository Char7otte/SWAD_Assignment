FoodItem margheritaPizza = new FoodItem("Margherita Pizza", 14.99, "Classic pizza with tomato sauce, fresh mozzarella, and basil.", "images/margherita.jpg");
margheritaPizza.available = false;
FoodItem caesarSalad = new FoodItem("Caesar Salad", 9.50, "Crisp romaine lettuce with parmesan, croutons, and our homemade Caesar dressing.", "images/caesar.jpg");
FoodItem chocolateLavaCake = new FoodItem("Chocolate Lava Cake", 8.25, "Warm chocolate cake with a molten center, served with vanilla ice cream.", "images/lava-cake.jpg");

FoodStall foodStall1 = new("The Gilded Fork", new List<FoodItem>([margheritaPizza, caesarSalad, chocolateLavaCake]));
Staff loggedInAccount = new Staff("foodStaff@gmail.com", "123", "Jerry Tan", foodStall1);

EditMenu editMenu = new();

while (true)
{
    Console.WriteLine($"Welcome, {loggedInAccount} of {loggedInAccount.foodStall}");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Update menu");
    Console.WriteLine("0. Exit");
    var input = Console.ReadLine();

    if (input == "0") Environment.Exit(0);
    else if (input == "1") updateMenu(loggedInAccount);
    else Console.WriteLine("Please enter a valid option!");
}

void updateMenu(Staff account)
{
    while (true)
    {
        Console.WriteLine();
        getMenu(account.foodStall);
        Console.WriteLine("1. Modify existing item");
        Console.WriteLine("2. Add new item");
        Console.WriteLine("0. Return");
        var input = Console.ReadLine();

        if (input == "0") break;
        else if (input == "1") modifyItem(account.foodStall);
        else if (input == "2") createNewItem(account.foodStall);
        else Console.WriteLine("Please enter a valid option!");
    }
}

void modifyItem(FoodStall fs)
{
    Console.WriteLine("What item do you want to modify?");
    var input = Console.ReadLine();
    try
    {
        FoodItem fi = editMenu.selectFoodItem(fs, int.Parse(input));
        Console.WriteLine();
        Console.WriteLine(fi);
        Console.WriteLine();
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Update item information");
        Console.WriteLine("2. Change availability");
        Console.WriteLine("3. Delete item");
        Console.WriteLine("0. Cancel");

        input = Console.ReadLine();
        if (input == "0") return;
        else if (input == "1") updateItemInformation(fi);
        else if (input == "2") toggleAvailability(fi);
        else if (input == "3") deleteItem(fs, fi);
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

void updateItemInformation(FoodItem fi)
{
    Console.WriteLine();
    Console.WriteLine("What would you like to update?");
    Console.WriteLine("1. Name");
    Console.WriteLine("2. Price");
    Console.WriteLine("3. Description");
    Console.WriteLine("4. Product photo");
    Console.WriteLine("0. Cancel");
    var input = Console.ReadLine();

    if (input == "0") return;
    else if (input == "1") updateName(fi);
    else if (input == "2") updatePrice(fi);
    else if (input == "3") updateDescription(fi);
    else if (input == "4") updatePhoto(fi);
}

void updateName(FoodItem fi)
{
    Console.WriteLine("Enter new name: ");
    string name = Console.ReadLine();
    string newName = editMenu.updateName(fi, name);
    printSuccessMessage($"Name updated to {newName}");
}

void updatePrice(FoodItem fi)
{
    Console.WriteLine("Enter new price: ");
    double price = double.Parse(Console.ReadLine());
    double newPrice = editMenu.updatePrice(fi, price);
    printSuccessMessage($"Price updated to ${price}");
}

void updateDescription(FoodItem fi)
{
    Console.WriteLine("Enter new description: ");
    string description = Console.ReadLine();
    string newDescription = editMenu.updateDescription(fi, description);
    printSuccessMessage($"Description updated to {newDescription}");
}

void updatePhoto(FoodItem fi)
{
    Console.WriteLine("Upload new product photo:  ");
    string imgUrl = Console.ReadLine();
    string newPhoto = editMenu.updatePhoto(fi, imgUrl);
    printSuccessMessage($"Product photo updated to {newPhoto}");
}

void toggleAvailability(FoodItem fi)
{
    bool itemAvailability = editMenu.toggleAvailability(fi);
    printSuccessMessage($"{fi.Name} is now {(!itemAvailability ? "hidden" : "available for order")}.");
}

void deleteItem(FoodStall fs, FoodItem fi)
{
    string itemName = editMenu.deleteItem(fs, fi);
    printSuccessMessage($"{itemName} has been deleted.");
}

void printSuccessMessage(string message)
{
    Console.WriteLine(message);
    Console.ReadLine();
}

void createNewItem(FoodStall fs)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Enter name: (Or enter 0 to cancel)");
            string name = Console.ReadLine();
            if (name == "0") break;

            Console.WriteLine("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Upload product photo: ");
            string imgUrl = Console.ReadLine();

            FoodItem newFoodItem = new(name, price, description, imgUrl);
            string itemName = editMenu.addFoodItem(fs, newFoodItem);
            printSuccessMessage($"{itemName} has been added to {fs}");
            break;
        }
        catch
        {
            Console.WriteLine("Error. Please try again.");
        }
    }
}

void getMenu(FoodStall fs)
{
    List<FoodItem> foodItems = editMenu.getMenu(fs);
    displayMenu(fs.Name, foodItems);
}

void displayMenu(string name, List<FoodItem> foodItems)
{
    var index = 1;
    Console.WriteLine($"{name}'s menu");
    foreach (var item in foodItems)
    {
        Console.WriteLine($"{index}.{item} ");
        Console.WriteLine();
        index++;
    }
    Console.WriteLine("--------------------------------------------");
}

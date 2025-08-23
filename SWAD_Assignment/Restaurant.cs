public class Restaurant
{
    public string Name;
    public List<MenuItem> menuItems;

    public Restaurant(string name)
    {
        Name = name;
        menuItems = new();
    }

    public Restaurant(string name, List<MenuItem> menuItems)
    {
        Name = name;
        this.menuItems = menuItems;
    }

    public void addMenuItem(MenuItem newMenuItem)
    {
        menuItems.Add(newMenuItem);
    }

    public void displayMenu()
    {
        var index = 1;
        Console.WriteLine($"{this}'s menu");
        foreach (var item in menuItems)
        {
            Console.WriteLine($"{index}. {item} ");
            Console.WriteLine();
            index++;
        }
        Console.WriteLine("--------------------------------------------");
    }

    public MenuItem selectMenuItem(int index)
    {
        return menuItems[index - 1];
    }

    public override string ToString()
    {
        return Name;
    }

    public void modifyItem()
    {
        Console.WriteLine("What item do you want to modify?");
        var input = Console.ReadLine();
        try
        {
            MenuItem menuItem = selectMenuItem(int.Parse(input));
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
            else if (input == "2") menuItem.toggleDisabled();
            else if (input == "3")
            {
                string itemName = menuItem.Name;
                menuItems.Remove(menuItem);
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

    public void createNewItem()
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

                MenuItem newMenuItem = new(name, price, description, imgUrl);
                addMenuItem(newMenuItem);
                break;
            }
            catch
            {
                Console.WriteLine("Error. Please try again.");
            }
        }
    }
}
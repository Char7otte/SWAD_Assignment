class FoodStaff
{
    public string Name { get; set; }
    public Restaurant restaurant { get; set; }

    public FoodStaff(string name, Restaurant restaurant)
    {
        Name = name;
        this.restaurant = restaurant;
    }

    public override string ToString()
    {
        return Name;
    }
}
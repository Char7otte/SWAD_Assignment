class Staff: Account
{
    public FoodStall foodStall { get; set; }

    public Staff(string email, string password, string name, FoodStall foodStall): base(email, password, name)
    {
        this.foodStall = foodStall;
    }

    public override string ToString()
    {
        return Name;
    }
}
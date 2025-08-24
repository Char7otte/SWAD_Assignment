abstract class Account
{
    private string email;
    private string password;

    public string Name { get; set; }

    public Account(string email, string password, string name)
    {
        this.email = email;
        this.password = password;
        Name = name;
    }
}
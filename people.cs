public class People
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine("ID: "+Id);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Email: "+Email);
    }
}

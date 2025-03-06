public class Client
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public List<VirtualNumber> AssignedNumbers { get; set; }

    public Client(int id, string name, string email)
    {
        ClientId = id;
        Name = name;
        Email = email;
        AssignedNumbers = new List<VirtualNumber>();
    }

    public void AssignNumber(VirtualNumber number)
    {
        AssignedNumbers.Add(number);
    }
}

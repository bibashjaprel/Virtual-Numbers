public class VirtualNumber
{
    public string Number { get; set; }
    public bool IsActive { get; set; }
    public Client AssignedClient { get; set; }

    public VirtualNumber(string number)
    {
        Number = number;
        IsActive = true;
    }

    public void AssignToClient(Client client)
    {
        AssignedClient = client;
    }
}

public class SMSRecord
{
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public string Message { get; set; }
    public DateTime SentTime { get; set; } = DateTime.Now;

    public SMSRecord(string sender, string receiver, string message)
    {
        Sender = sender;
        Receiver = receiver;
        Message = message;
    }
}

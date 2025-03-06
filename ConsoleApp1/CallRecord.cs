public class CallRecord
{
    public string Caller { get; set; }
    public string Receiver { get; set; }
    public DateTime CallTime { get; set; }
    public int Duration { get; set; }

    public CallRecord(string caller, string receiver, int duration)
    {
        Caller = caller;
        Receiver = receiver;
        CallTime = DateTime.Now;
        Duration = duration;
    }
}

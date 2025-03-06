using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Client client1 = new Client(1, "John Doe", "john@example.com");
        Client client2 = new Client(2, "Alice Smith", "alice@example.com");

        VirtualNumber number1 = new VirtualNumber("+1234567890");
        VirtualNumber number2 = new VirtualNumber("+9876543210");

        client1.AssignNumber(number1);
        number1.AssignToClient(client1);

        client2.AssignNumber(number2);
        number2.AssignToClient(client2);

        CallRecord call1 = new CallRecord("+1234567890", "+9876543210", 300); // 5-minute call
        Console.WriteLine($"Call logged: {call1.Caller} -> {call1.Receiver} at {call1.CallTime}, Duration: {call1.Duration} seconds");

        SMSRecord sms1 = new SMSRecord("+9876543210", "+1234567890", "Hello, how are you?");
        Console.WriteLine($"SMS logged: {sms1.Sender} -> {sms1.Receiver} at {sms1.SentTime}, Message: {sms1.Message}");

        // Display Client Info
        Console.WriteLine("\nClient and Number Details:");
        DisplayClientInfo(client1);
        DisplayClientInfo(client2);
    }

    static void DisplayClientInfo(Client client)
    {
        Console.WriteLine($"Client: {client.Name} ({client.Email})");
        foreach (var number in client.AssignedNumbers)
        {
            Console.WriteLine($"   Assigned Number: {number.Number}, Active: {number.IsActive}");
        }
    }
}

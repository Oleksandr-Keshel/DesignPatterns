public sealed class Messenger 
{
    private int numOfMessages;
    private static Messenger messenger = null;
    private Messenger(){}
    public static Messenger getIstance(){
        if(messenger == null){
            messenger = new Messenger();
            messenger.numOfMessages = 0;
        }
        return messenger;
    }
    public void SendMessage(string recipient, string message){
        this.numOfMessages++;
        Console.WriteLine($"To: {recipient} \nMessage: {message}");
        Console.WriteLine("Number of messages: " + this.numOfMessages);

        if(message.ToLower().Contains("бомба")){
            Messenger.ReportToPolice(recipient, message);
        }
    }
    private static void ReportToPolice(string recipient, string message){
        Console.WriteLine($"!!!Message contains the word 'bomb': \"{message}\" - Recipient: {recipient}!!!");
    }
}
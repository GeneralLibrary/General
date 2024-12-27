namespace GeneralKernel.Core;

public class Message
{
    public string Content { get; set; }
    
    public string Title { get; set; }
    
    public DateTime CreateDateTime { get; set; }
    
    public MessageType Type { get; set; }
}
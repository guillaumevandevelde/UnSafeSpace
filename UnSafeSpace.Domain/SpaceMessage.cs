namespace UnSafeSpace.Domain;

public class SpaceMessage
{

    public int Id { get; set; }
    public string? Message { get; set; }

    public string? Sender { get; set; }
    public string? Recipient { get; set; }

}

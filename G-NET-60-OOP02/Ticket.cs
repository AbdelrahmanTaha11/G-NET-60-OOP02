
namespace G_NET_60_OOP02;

internal class Ticket
{

    private string movieName;
    private double price;
    private static int ticketCounter = 0;

    public int TicketId { get; }

    public string MovieName
    {
        get => movieName;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                movieName = value;
        }
    }

    public TicketType Type { get; set; }

    public SeatLocation Seat { get; set; }

    public double Price
    {
        get => price;
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public double PriceAfterTax => Price * 1.14;

    public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
    {
        TicketId = ++ticketCounter;
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
    }

    public static int GetTotalTicketsSold()
    {
        return ticketCounter;
    }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} | {Type} | Seat: {Seat} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP";
    }
}




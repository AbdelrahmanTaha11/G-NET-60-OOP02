
namespace G_NET_60_OOP02;

internal enum TicketType
{

    Standard,
    VIP,
    IMAX

}

struct SeatLocation
{
    public SeatLocation(char row, int number)
    {
        Row = row;
        Number = number;
    }

    public char Row { get; set; }
    public int Number { get; set; }



    public override string ToString()
    {
        return $"{Row}-{Number}";
    }



}
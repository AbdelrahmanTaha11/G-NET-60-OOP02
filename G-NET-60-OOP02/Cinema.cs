

namespace G_NET_60_OOP02
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];

        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < tickets.Length)
                    return tickets[index];

                return null;
            }
            set
            {
                if (index >= 0 && index < tickets.Length)
                    tickets[index] = value;
            }
        }

        public Ticket this[string movieName]
        {
            get
            {
                foreach (var ticket in tickets)
                {
                    if (ticket != null &&
                        ticket.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                        return ticket;
                }

                return null;
            }
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }

            return false;
        }
    }

    static class BookingHelper
    {
        private static int counter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double total = numberOfTickets * pricePerTicket;

            if (numberOfTickets >= 5)
                total *= 0.9;

            return total;
        }

        public static string GenerateBookingReference()
        {
            return $"BK-{++counter}";
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movieName, double price, string seat)
            : base(movieName, price)
        {
            Seat = seat;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketNumber}] {MovieName} | Standard | Seat: {Seat} | " +
                $"Price: {Price} | After Tax: {CalculateAfterTax()} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public override object Clone()
        {
            return new StandardTicket(MovieName, Price, Seat);
        }
    }
}

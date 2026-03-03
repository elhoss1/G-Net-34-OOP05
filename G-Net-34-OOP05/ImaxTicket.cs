using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05
{
    public class ImaxTicket : Ticket
    {
        public bool Is3D { get; set; }

        public ImaxTicket(string movieName, double price, bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketNumber}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | " +
                $"Price: {Price} | After Tax: {CalculateAfterTax()} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public override object Clone()
        {
            return new ImaxTicket(MovieName, Price, Is3D);
        }
    }
}

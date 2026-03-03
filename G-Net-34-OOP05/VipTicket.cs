using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05
{
    public class VipTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public double ExtraFee { get; set; }

        public VipTicket(string movieName, double price, bool loungeAccess, double extraFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            ExtraFee = extraFee;
        }

        public override void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketNumber}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
                $"Fee: {ExtraFee} | Price: {Price} | After Tax: {CalculateAfterTax()} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public override object Clone()
        {
            return new VipTicket(MovieName, Price, LoungeAccess, ExtraFee);
        }
    }
}

using G_Net_34_OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace G_Net_34_OOP05
{
    public class Cinema
    {
        private List<IPrintable> tickets = new List<IPrintable>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void Close()
        {
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void AddTicket(IPrintable ticket)
        {
            tickets.Add(ticket);
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets ---");
            foreach (var ticket in tickets)
            {
                ticket.Print();
            }
        }
    }
}

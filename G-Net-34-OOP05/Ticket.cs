using G_Net_34_OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05
{
    public abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 1;

        public int TicketNumber { get; private set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, double price)
        {
            TicketNumber = counter++;
            MovieName = movieName;
            Price = price;
            IsBooked = false;
        }

        public double CalculateAfterTax()
        {
            return Price * 1.14;
        }

        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        public abstract void Print();

        public abstract object Clone();


    }

}
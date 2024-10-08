using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class Without_Null_Coalescing_Operator
    {
        static void Main()
        {
            int? TicketsOnSale = null;
            int AvailableTicket;
            if (TicketsOnSale == null)
            {
                AvailableTicket = 0;
            }
            else
            {
                AvailableTicket = TicketsOnSale.Value;
            }
            Console.WriteLine("AvailableTicket:"+AvailableTicket);
            Console.ReadLine();
        }
    }
}

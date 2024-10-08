using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Training
{
    internal class With_Null_Coalescing_Operator
    {
        static void Main()
        {
            int? TicketOnSale = 100;
            int AvailableTicket;
            //for indicate null value we use ??
            AvailableTicket = TicketOnSale ?? 0;
            Console.WriteLine("AvailableTickets:"+AvailableTicket);
            Console.ReadLine();

        }
    }
}

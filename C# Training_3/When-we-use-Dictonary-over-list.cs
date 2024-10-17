using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training3
{
    public class Country
    {
        public string Name { get; set; }
        public string code { get; set; }
        public string captial { get; set; }
    }
    internal class When_we_use_Dictonary_over_list
    {
        static void Main()
        {
            Country country1 = new Country() { Name = "AUSTRALIA", code = "AUS", captial = "Canberra" };
            Country country2 = new Country() {Name="INDIA",code="IND",captial="New Delhi" };
            Country country3 = new Country() {Name="UNITED STATES",code="USA",captial="Washington D.C" };
            Country country4 = new Country() {Name="UNITED KINGDOM",code="GBR",captial="London" };
            Country country5 = new Country() {Name="CANADA",code="CAN",captial="Ottawa" };

        }
    }
}

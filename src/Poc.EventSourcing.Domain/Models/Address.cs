using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.EventSourcing.Domain.Models
{
    public class Address
    {
        public Address(string physicalAddress, string postCode, string state, string country)
        {
            PhysicalAddress = physicalAddress;
            PostCode = postCode;
            State = state;
            Country = country;
        }
        public string PhysicalAddress { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}

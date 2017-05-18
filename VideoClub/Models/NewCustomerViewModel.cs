using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoClub.Models
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MemberShipType> MemberShipType{ get; set; }
        public Customer Customers { get; set; }

    }
}
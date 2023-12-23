using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocıalMedıa.Models
{
    public class CusplusLocation
    {
        public List<Customer> Customer_List { get; internal set; }

        public List<Location> Location_List { get; internal set; }
    }
}
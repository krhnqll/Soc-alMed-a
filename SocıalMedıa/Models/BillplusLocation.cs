using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocıalMedıa.Models
{
    public class BillplusLocation
    {
        public List<Billboard> Billboard_List { get; internal set; }

        public List<Location> Locations { get; internal set; }
    }
}
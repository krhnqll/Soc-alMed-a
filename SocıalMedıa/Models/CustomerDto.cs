using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocıalMedıa.Models
{
    public class CustomerDto
    {
        public int Cus_id { get; set; }
        public string Cus_name { get; set; }
        public string Cus_surname { get; set; }
        public string Cus_email { get; set; }
        public string Cus_phonenumber { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string Loc_name { get; set; }
    }
}
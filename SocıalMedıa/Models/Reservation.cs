//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocıalMedıa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int Res_id { get; set; }
        public Nullable<int> Res_time { get; set; }
        public string Res_company { get; set; }
        public string Res_detail { get; set; }
        public Nullable<int> Cus_id { get; set; }
        public Nullable<int> Total_price { get; set; }
        public Nullable<int> Billboard_id { get; set; }
    
        public virtual Billboard Billboard { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

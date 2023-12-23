
namespace SocıalMedıa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Reservation = new HashSet<Reservation>();
        }
    
        public int Cus_id { get; set; }
        public string Cus_name { get; set; }
        public string Cus_surname { get; set; }
        public string Cus_email { get; set; }
        public string Cus_phonenumber { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> Loc_id { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}

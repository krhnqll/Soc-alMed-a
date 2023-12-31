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
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public partial class Billboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Billboard()
        {
            this.Reservation = new HashSet<Reservation>();
        }
       
        public int Billboard_id { get; set; }

        [Required(ErrorMessage = "Bu Alan Zorunlu")]
        public string Billboard_name { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunlu")]
        public string Billboard_detail { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunlu")]
        public string Billboard_status { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunlu")]
        public Nullable<int> Billboard_height { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunlu")]
        public Nullable<int> Billboard_width { get; set; }

        [Required(ErrorMessage ="Bu Alan Zorunlu")]
        public Nullable<int> Loc_id { get; set; }
    
        public virtual Location Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Location> locations { get; set; }
    }
}

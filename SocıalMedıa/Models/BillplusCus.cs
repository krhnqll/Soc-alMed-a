using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SocıalMedıa.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class BillplusCus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

       
          
        public List<Billboard> Billboard_List { get; internal set; }
        public List<Customer> Customer_List { get; internal set; }

        public Location location { get; internal set; }

        List<SocıalMedıaEntities> DataList = new List<SocıalMedıaEntities>();        
        
    }
}
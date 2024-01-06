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



        public List<CusplusLocation> Customer_List { get; internal set; }
        public List<BillplusLocation> Billboard_List { get; internal set; }


        public Location location { get; internal set; }

        List<SocıalMedıaEntities1> DataList = new List<SocıalMedıaEntities1>();

    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carnotaurus.GhostPubsMvc.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public int TagID { get; set; }
        public System.DateTime LastModified { get; set; }
        public Nullable<int> OrgID { get; set; }
        public int FeatureID { get; set; }
    
        public virtual Org Org { get; set; }
        public virtual Feature Feature { get; set; }
    }
}

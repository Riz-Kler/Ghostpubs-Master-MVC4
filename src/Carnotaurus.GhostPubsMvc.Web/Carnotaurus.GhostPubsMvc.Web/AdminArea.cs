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
    
    public partial class AdminArea
    {
        public int AdminAreaID { get; set; }
        public Nullable<int> CountyID { get; set; }
        public string Name { get; set; }
    
        public virtual County County { get; set; }
    }
}

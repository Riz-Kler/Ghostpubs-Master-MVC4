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
    
    public partial class County
    {
        public County()
        {
            this.Orgs = new HashSet<Org>();
            this.AdminAreas = new HashSet<AdminArea>();
        }
    
        public int CountyID { get; set; }
        public int RegionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual Region Region { get; set; }
        public virtual ICollection<Org> Orgs { get; set; }
        public virtual ICollection<AdminArea> AdminAreas { get; set; }
    }
}
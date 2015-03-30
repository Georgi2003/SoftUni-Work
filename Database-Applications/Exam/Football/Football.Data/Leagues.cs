//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leagues
    {
        public Leagues()
        {
            this.InternationalMatches = new HashSet<InternationalMatches>();
            this.TeamMatches = new HashSet<TeamMatches>();
            this.Teams = new HashSet<Teams>();
        }
    
        public int Id { get; set; }
        public string LeagueName { get; set; }
        public string CountryCode { get; set; }
    
        public virtual Countries Countries { get; set; }
        public virtual ICollection<InternationalMatches> InternationalMatches { get; set; }
        public virtual ICollection<TeamMatches> TeamMatches { get; set; }
        public virtual ICollection<Teams> Teams { get; set; }
    }
}

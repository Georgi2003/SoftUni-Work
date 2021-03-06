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
    
    public partial class InternationalMatches
    {
        public int Id { get; set; }
        public string HomeCountryCode { get; set; }
        public string AwayCountryCode { get; set; }
        public Nullable<int> HomeGoals { get; set; }
        public Nullable<int> AwayGoals { get; set; }
        public Nullable<System.DateTime> MatchDate { get; set; }
        public Nullable<int> LeagueId { get; set; }
    
        public virtual Countries Countries { get; set; } // away country
        public virtual Countries Countries1 { get; set; } // home country
        public virtual Leagues Leagues { get; set; }
    }
}

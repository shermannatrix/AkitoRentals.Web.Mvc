//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AkitoRentals.Web.Mvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarMileage
    {
        public int MileageId { get; set; }
        public int CarId { get; set; }
        public Nullable<int> UsageMonth { get; set; }
        public Nullable<int> UsageYear { get; set; }
        public Nullable<decimal> DistanceTraveled { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Car Car { get; set; }
    }
}
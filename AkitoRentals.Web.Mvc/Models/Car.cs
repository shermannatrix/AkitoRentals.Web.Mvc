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
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarMileages = new HashSet<CarMileage>();
            this.RentalHistories = new HashSet<RentalHistory>();
        }
    
        public int CarId { get; set; }
        public string VehicleNo { get; set; }
        public string RentalCarCode { get; set; }
        public int TypeId { get; set; }
        public int ModelId { get; set; }
        public int MakeId { get; set; }
        public Nullable<int> AvailabilityId { get; set; }
        public Nullable<int> YearsOfUse { get; set; }
        public Nullable<int> MonthsOfUse { get; set; }
        public Nullable<int> SeatingCapacity { get; set; }
        public string ExteriorPhotoUrl { get; set; }
        public string InteriorPhotoUrl { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        public virtual CarAvailability CarAvailability { get; set; }
        public virtual CarModel CarModel { get; set; }
        public virtual CarStatus CarStatus { get; set; }
        public virtual CarType CarType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMileage> CarMileages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalHistory> RentalHistories { get; set; }
    }
}
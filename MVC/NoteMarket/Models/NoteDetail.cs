//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoteMarket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NoteDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NoteDetail()
        {
            this.Buyers = new HashSet<Buyer>();
            this.Ratings = new HashSet<Rating>();
            this.Sellers = new HashSet<Seller>();
        }
    
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string NoteTitle { get; set; }
        public string Category { get; set; }
        public string DisplayPic { get; set; }
        public string Preview { get; set; }
        public string Type { get; set; }
        public string NoOfPages { get; set; }
        public string Description { get; set; }
        public string University { get; set; }
        public string Country { get; set; }
        public string CourseCode { get; set; }
        public string Course { get; set; }
        public string Professor { get; set; }
        public bool SellFor { get; set; }
        public string SellPrice { get; set; }
        public string Status { get; set; }
        public System.DateTime ReqDate { get; set; }
        public System.DateTime ApprovedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buyer> Buyers { get; set; }
        public virtual MembersData MembersData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}

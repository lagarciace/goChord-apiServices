//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace goChord.goChordDb.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Songbook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Songbook()
        {
            this.SongbookByUser = new HashSet<SongbookByUser>();
            this.SongBySongbook = new HashSet<SongBySongbook>();
        }
    
        public int songbookId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string version { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SongbookByUser> SongbookByUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SongBySongbook> SongBySongbook { get; set; }
    }
}

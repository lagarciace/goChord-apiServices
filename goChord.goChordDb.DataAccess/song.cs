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
    
    public partial class Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            this.CategoriesBySong = new HashSet<CategoriesBySong>();
            this.SongBySongbook = new HashSet<SongBySongbook>();
        }
    
        public int songId { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string songkey { get; set; }
        public string lyrics { get; set; }
        public string chordpro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriesBySong> CategoriesBySong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SongBySongbook> SongBySongbook { get; set; }
    }
}

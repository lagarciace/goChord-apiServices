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
    
    public partial class SongBySongbook
    {
        public int songsBySongbookId { get; set; }
        public int songbookId { get; set; }
        public int songId { get; set; }
    
        public virtual Song Song { get; set; }
        public virtual Songbook Songbook { get; set; }
    }
}

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
    
    public partial class CategoriesBySong
    {
        public int categoriesBySongId { get; set; }
        public int songId { get; set; }
        public int categoryId { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Song Song { get; set; }
    }
}

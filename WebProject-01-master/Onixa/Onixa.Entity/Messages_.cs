//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Onixa.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Messages_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Messages_()
        {
            this.MessagesReplies = new HashSet<MessagesReplies>();
        }
    
        public int Id { get; set; }
        public string Subject { get; set; }
        public bool IsRead { get; set; }
        public System.DateTime AddedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> Member_From_Id { get; set; }
        public Nullable<int> Member_To_Id { get; set; }
        public string UserBy { get; set; }
    
        public virtual Members Members { get; set; }
        public virtual Members Members1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessagesReplies> MessagesReplies { get; set; }
    }
}
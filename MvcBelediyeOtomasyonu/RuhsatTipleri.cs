//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBelediyeOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class RuhsatTipleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RuhsatTipleri()
        {
            this.KirsalYapiRuhsatlari = new HashSet<KirsalYapiRuhsatlari>();
            this.Ruhsatlar = new HashSet<Ruhsatlar>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SaveUserId { get; set; }
        public string SaveDate { get; set; }
        public Nullable<int> EditUserId { get; set; }
        public string EditDate { get; set; }
        public string Tip { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KirsalYapiRuhsatlari> KirsalYapiRuhsatlari { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Kullanicilar Kullanicilar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ruhsatlar> Ruhsatlar { get; set; }
    }
}

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
    using System.Web.Mvc;

    public partial class Ruhsatlar
    {
        public int Id { get; set; }
        public Nullable<int> RuhsatTipId { get; set; }
        public Nullable<int> IskanTipId { get; set; }
        public Nullable<int> SaveUserId { get; set; }
        public string SaveDate { get; set; }
        public Nullable<int> EditUserId { get; set; }
        public string EditDate { get; set; }
        public string RuhsatNo { get; set; }
        public string RuhsatSahibi { get; set; }
        public string TcNo { get; set; }
        public string VergiNo { get; set; }
        public string Ada { get; set; }
        public string Parsel { get; set; }
        public string InsaatAdresi { get; set; }
        public string RuhsatBilgileri { get; set; }
        public string RuhsatTarihi { get; set; }
        public Nullable<decimal> InsaatHarci { get; set; }
        public string YapiDenetim { get; set; }
        public string SantiyeSefi { get; set; }
        public string IskanTarihi { get; set; }
        public string Muteahhit { get; set; }
        public string Aciklama { get; set; }
        public string DigerBilgiler { get; set; }
        public string Tarama0 { get; set; }
        public string Tarama1 { get; set; }
        public string Tarama2 { get; set; }
        public string Tarama3 { get; set; }
        public string Tarama4 { get; set; }
        public string Tarama5 { get; set; }
        public string Tarama6 { get; set; }
        public string Tarama7 { get; set; }
        public string Tarama8 { get; set; }
        public string Tarama9 { get; set; }
        public string ProjeDosyasi { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<bool> Silindi { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Kullanicilar Kullanicilar1 { get; set; }
        public virtual RuhsatTipleri RuhsatTipleri { get; set; }
        public List<SelectListItem> RuhsatTipListesi { get; set; }
    }
}
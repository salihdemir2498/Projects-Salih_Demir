using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Core_Mvc_Code.Models
{
    public partial class Yazarlar
    {
        public Yazarlar()
        {
            Kitaplars = new HashSet<Kitaplar>();
        }

        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int? TurId { get; set; }

        public virtual Turler Tur { get; set; }
        public virtual ICollection<Kitaplar> Kitaplars { get; set; }
    }
}

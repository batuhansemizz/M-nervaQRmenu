using System.ComponentModel.DataAnnotations; // key kullanınca otomatik olarak yüklenir 

namespace MınervaQRmenu.Models
{
    public class KitapTuru
    {
        [Key]  // primary key anlamına gelir
        public int Id { get; set; }

        [Required] // null olamaz anlamına geliyor    
        public string Ad { get; set; }
        

    }
}

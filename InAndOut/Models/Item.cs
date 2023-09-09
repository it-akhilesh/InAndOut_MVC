using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Borrower")]
        public string Borrower { get; set; }
        [DisplayName("Lender")]
        public string Lender { get; set; }
        [DisplayName("ItemName")]
        public string ItemName { get; set; }
    }
}

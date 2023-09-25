using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class ExpenseType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

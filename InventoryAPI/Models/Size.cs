using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryAPI.Models
{
    public class Size
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public string Name { get; set; }
    }
}

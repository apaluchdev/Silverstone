using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Silverstone.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,int.MaxValue,ErrorMessage = "Value must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace home_56.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните название")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Заполните описание")]
        public string? Description { get; set; }
    }
}

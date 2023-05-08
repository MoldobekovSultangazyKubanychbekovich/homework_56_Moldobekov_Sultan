using System.ComponentModel.DataAnnotations;

namespace home_56.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните имя бренда")]
        public string Name { get; set; }
    }
}

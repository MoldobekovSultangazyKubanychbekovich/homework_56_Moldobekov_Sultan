using System.ComponentModel.DataAnnotations;

namespace home_56.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указано имя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина имени должна быть от 3 до 50 символов")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Загрузите url картинки")]
        public string? Image { get; set; }
        [Required(ErrorMessage = "Установите цену")]
        [Range(50, 1000000, ErrorMessage = "Установите цену не ниже 50")]
        public int Price { get; set; }
        public string? DateCreate { get; set; }
        public string? DateUpdate { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public Product()
        {
            DateCreate = DateTime.Now.ToString();
            DateUpdate = null;
        }

    }
}

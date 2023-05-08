using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace home_56.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя заказчика")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Укажите адресс заказчика")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Укажите телефон заказчика")]
        public string? ContactPhone { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}

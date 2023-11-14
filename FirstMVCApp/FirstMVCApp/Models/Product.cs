using System.ComponentModel.DataAnnotations;

namespace FirstMVCApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name="Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    }
}

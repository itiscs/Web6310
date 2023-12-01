using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApp.Models
{
    //[Table("NewProduct")]
    public class Product
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Key]
        public int Id { get; set; }

        [Display(Name="Название")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [MaxLength(1000)]
        //[Compare("Name",ErrorMessage = "поля должны совпадать")]
        public string? Description { get; set; }

        [Display(Name = "Картинка")]
        [RegularExpression(@"\w*.jpg$")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Цена")]
        [Range(0,10000)]
        public decimal? Price { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        [Display(Name = "Категория")]
        public Category? Category { get; set; }

        //[NotMapped]
        //public int CompProp { get; set; }
    }
}

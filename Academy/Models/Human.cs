using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
    public class Human
    {
        [Required]
        [StringLength(50)]
        [DisplayName("Фамилия")]
        [RegularExpression(@"^[A-ZА-Я][a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string last_name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Имя")]
        [RegularExpression(@"^[A-ZА-Я][a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string first_name { get; set; }

        [StringLength(50)]
        [DisplayName("Отчество")]
        [RegularExpression(@"^[A-ZА-Я][a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string? middle_name { get; set; }

        [Required]
        [DisplayName("Дата рождения")]
        [Range(typeof(DateOnly), "1940-01-01", "2015-12-31")]
        public DateOnly birth_date { get; set; }

        public string? email { get; set; } // [EmailAddress] - сделает поле обязательным для заполнения (not null)

        public string? phone { get; set; } // [Phone] - сделает поле обязательным для заполнения (not null)
        public byte[]? photo { get; set; }

        public string full_name
        {
            get => $"{last_name} {first_name} {middle_name}";
        }
    }
}

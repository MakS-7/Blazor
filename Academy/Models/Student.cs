using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Student
    {
        [Key]
        public int stud_id { get; set; }

        public string last_name { get; set; }
        public string first_name { get; set; }
        public string? middle_name { get; set; }

        [Column("birth_date", TypeName = "DATE")]
        public DateOnly birth_date { get; set; }

        public string? email { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 6)]
        public string? phone { get; set; }

        [Column("photo", TypeName = "image")]
        public string? photo { get; set; }

        [ForeignKey(nameof(Group))]
        public int? group { get; set; }

        public Group? Group { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    [PrimaryKey(nameof(teacher), nameof(discipline))]
    public class TeachersDisciplinesRelation
    {
        [ForeignKey(nameof(Teacher))]
        [Column(TypeName = "SMALLINT")]
        public int teacher { get; set; }

        [ForeignKey(nameof(Discipline))]
        [Column(TypeName = "SMALLINT")]
        public int discipline { get; set; }

        public Teacher Teacher { get; set; }
        public Discipline Discipline { get; set; }
    }
}

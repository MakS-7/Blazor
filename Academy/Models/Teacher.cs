namespace Academy.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}

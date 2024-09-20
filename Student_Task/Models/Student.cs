using System.ComponentModel.DataAnnotations;

namespace Student_Task.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }
         
        public string email { get; set; }
        public string Address { get; set; }

        public List<string> Subject { get; set; }
    }
}

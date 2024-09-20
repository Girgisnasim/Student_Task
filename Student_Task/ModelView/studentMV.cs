using System.ComponentModel.DataAnnotations;

namespace Student_Task.ModelView
{
    public class studentMV
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name contains numbers or special characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string email { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "At least one subject must be chosen")]
        [MaxLength(2, ErrorMessage = "You can only choose up to 2 subjects.")]
        public List<string> Subject { get; set; }
    }
}

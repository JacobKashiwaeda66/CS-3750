using System.ComponentModel.DataAnnotations;

namespace RegisterPage.model
{
    public class register
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? username { get; set; }

        [Required]
        public string? password { get; set; }

        [Required]
        public string? firstname { get; set; }

        [Required]
        public string? lastname { get; set; }

        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
    }
}

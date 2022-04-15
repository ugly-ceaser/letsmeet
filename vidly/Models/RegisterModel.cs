using System;
using System.ComponentModel.DataAnnotations;
namespace vidly.Models
{
    public class RegisterModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        


        [Required]
        [DataType(DataType.Text)]
        public string username { get; set; }
        

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string stack { get; set; }

        [DataType(DataType.Text)]
        public string imgae { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;


namespace eUseControl.Models
{
    public class userInfo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter user name.")]
        [StringLength(50)]
        [Display(Name = "Name Surname")]
        public string Name { get; set; }

        [Phone]
        [Required]
        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [Display(Name = "Email Adress")]
        public string email { get; set; }

        public StyleTypes StyleTypes { get; set; }

        public int StyleTypesId { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Something has gone wrong !")]
        public string PicturePath { get; set; }

        [StringLength(128)]
        public string profileId { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharpCafeApp.Domain.Domain
{
    public class Author
    {
        public int Id { get; set; }

        [StringLength(160)]
        public string AppUserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(160)]
        [Display(Name = "User name")]
        public string DisplayName { get; set; }

        [Display(Name = "User bio")]
        public string Bio { get; set; }

        [StringLength(160)]
        public string Avatar { get; set; }

        public bool IsAdmin { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}

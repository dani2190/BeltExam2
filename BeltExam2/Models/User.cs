using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace BeltExam2.Models
{
    public class User
    {
        [Key]
            public int UserId { get; set; }

            [Required(ErrorMessage="Need something")]
            [MinLength(2, ErrorMessage="Name needs to be longer than 2 chars")]
            public string FirstName {get;set;}

            [Required(ErrorMessage="Need Last name")]
            public string LastName {get;set;}

            [EmailAddress]
            [Required]
            public string Email {get;set;}

            [DataType(DataType.Password)]
            [Required]
            [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
            public string Password {get;set;}

            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;

            // We us the NotMapped Annotation so that this variable doesn't end up in our database.
            [NotMapped]
            [Compare("Password")]
            [DataType(DataType.Password)]
            public string Confirm {get;set;}
            // public List<DojoActivity> MyActs {get;set;}
            // public List<Invite> MyInvites{get;set;}
            //displays the weddings that the user has created
    }
}
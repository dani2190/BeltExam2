using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace BeltExam2.Models
{
    public class DojoActivity
    {
        [Key]
        public int DojoActivityId {get;set;}
        [Required(ErrorMessage="Needs a Title")]
        public string Title {get;set;}
        public int Time {get;set;}
        public string StringTime {get;set;}


        [FutureDate]
        [Required]
        public DateTime ActivityDate { get; set; }

        public string Duration {get;set;}
        [Required(ErrorMessage="Needs a Description")]
        public string Description{get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId{get;set;}
        public User Creator{get;set;}
        public List<Invite> ActivityList{get;set;}
    }
    public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime)
        {
            DateTime compare = (DateTime)value;
            if(compare < DateTime.Now)
            {
            return new ValidationResult("Date must be in the future.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
        return new ValidationResult("Not a valid date");
        
    }
}
}
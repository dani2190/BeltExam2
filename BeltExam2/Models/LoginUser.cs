using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace BeltExam2.Models
{
        public class LoginUser
        {
            [Required]
            [EmailAddress]
            public string LogEmail { get; set; }

            [DataType(DataType.Password)]
            [Required]
            public string LogPassword {get;set;}
        }
    }
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace BeltExam2.Models
{
    public class Invite
    {
        [Key]
        public int InviteId{get;set;}
        public int DojoActivityId{get;set;}
        public int UserId {get;set;}
        public User NavUser{get;set;}
        public DojoActivity NavActivity{get;set;}
    }
}
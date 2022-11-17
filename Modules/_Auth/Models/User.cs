using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todolist.Modules._Auth.Models
{
    [Table("USERS")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [StringLength(30)]
        public string fullname { get; set; }
        [StringLength(100)]
        public string email { get; set; }
        [StringLength(100)]
        public string username { get; set; }
        [StringLength(100)]
        public string password { get; set; }
        public int sex { get; set; }
        [StringLength(200)]
        public string address { get; set; }
        public bool is_active { get; set; }
        public DateTime date_create { get; set; }
         public DateTime date_update { get; set; }
    }
}

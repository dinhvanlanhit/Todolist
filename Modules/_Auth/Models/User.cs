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
        public int ID { get; set; }
        [StringLength(30)]
        public string FULLNAME { get; set; }
        [StringLength(100)]
        public string EMAIL { get; set; }
        [StringLength(100)]
        public string USERNAME { get; set; }
        [StringLength(100)]
        public string PASSWORD { get; set; }
        public int SEX { get; set; }
        [StringLength(200)]
        public string ADDRESS { get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime DATE_CREATE { get; set; }
         public DateTime DATE_UPDATE { get; set; }
    }
}

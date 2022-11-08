using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todolist.Models
{
    [Table("TODOS")]
    public class Todo
    {
        [Key]
        public int ID { get; set; }
        [StringLength(255)]
        public string NAME { get; set; }
        public bool IS_ACTIVE { get; set; }
        public DateTime DATE_CREATE { get; set; }
        public DateTime DATE_UPDATE { get; set; }
    }
}

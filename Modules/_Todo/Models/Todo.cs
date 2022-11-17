using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todolist.Modules._Todo.Models
{
    [Table("TODOS")]
    public class Todo
    {
        [Key]
        public int id { get; set; }
        [StringLength(255)]
        public string name { get; set; }
        public bool is_active { get; set; }
        public DateTime date_create { get; set; }
        public DateTime date_update { get; set; }
    }
}

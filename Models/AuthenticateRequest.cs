using System.ComponentModel.DataAnnotations;

namespace Todolist.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string USERNAME { get; set; }

        [Required]
        public string PASSWORD { get; set; }
    }
}
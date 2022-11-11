using System.ComponentModel.DataAnnotations;

namespace Todolist.Modules._Auth.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string USERNAME { get; set; }

        [Required]
        public string PASSWORD { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Todolist.Modules._Auth.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
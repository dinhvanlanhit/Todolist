

namespace Todolist.Modules._Auth.Models
{
    public class AuthenticateResponse
    {
        public int id { get; set; }
        public string email { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string token { get; set; }


        public AuthenticateResponse(User user, string _token)
        {
            id = user.id;
            fullname = user.fullname;
            email = user.email;
            address = user.address;
            username = user.username;
            token = _token;
        }
    }
}


namespace Todolist.Models
{
    public class AuthenticateResponse
    {
        public int ID { get; set; }
        public string FULLNAME { get; set; }
        public string USERNAME { get; set; }
        public string TOKEN { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            ID = user.ID;
            FULLNAME = user.FULLNAME;
            USERNAME = user.USERNAME;
            TOKEN = token;
        }
    }
}
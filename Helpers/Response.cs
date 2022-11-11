namespace Todolist.Helpers
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public Response(string _message,bool _status)
        {
            Status = _status;
            Message = _message;
        }
    }
    // public class ResponseData
    // {
    //     public bool Status { get; set; }
    //     public string Message { get; set; }
    // }
}
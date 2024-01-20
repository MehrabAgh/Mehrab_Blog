namespace BlogUniversity.Models
{
    public class CommentModel(int _id , UserModel _user , string mess , DateTime time)
    {
        public int cid { get; set; } = _id;
        public UserModel user { get; set; } = _user;

        public DateTime datemessage { get; set; } = time;
        public string message { get; set; } = mess;
    }  
}

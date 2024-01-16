namespace BlogUniversity.Models
{
    public class CommentModel(int _id , UserModel _user , string mess)
    {
        public int cid { get; set; } = _id;
        public UserModel user { get; set; } = _user;
        public string message { get; set; } = mess;
    }  
}

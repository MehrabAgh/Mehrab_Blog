namespace BlogUniversity.Models
{
    public class UserModel (int _id ,string _name , string _email)
    {
        public int uid { get; set; } = _id;
        public string name { get; set; } = _name;
        public string email { get; set; } = _email;
    }
}

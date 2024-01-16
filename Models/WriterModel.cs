namespace BlogUniversity.Models
{
    public class WriterModel(int id , string fn, string ln, string role , string pn, string ip)
    {
        public int wid { get; set; } = id;
        public string FirstName { get; set; } = fn;
        public string LastName { get; set; } = ln;
        public string Role { get; set; } = role;
        public string PhoneNumber { get; set; } = pn;
        public string ImgProfile { get; set; } = ip;
    }
}

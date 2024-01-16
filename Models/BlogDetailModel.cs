namespace BlogUniversity.Models
{
    public class BlogDetailModel(int _id, List<string> _titles, List<string> _descriptions , List<string> _image
        , WriterModel _writer, DateTime _date, List<CommentModel> _comments , string _category)
    {
        public int pid { get; set; } = _id;
        public List<string> titles { get; set; } = _titles;
        public List<string> descriptions  { get; set; } = _descriptions;
        public List<string> images { get; set; } = _image;
        public WriterModel writer { get; set; } = _writer;
        public DateTime date { get; set; } = _date;
        public string category { get; set; } = _category;
        public List<CommentModel> comments = _comments;
    }
}

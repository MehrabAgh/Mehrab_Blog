using BlogUniversity.Models;
namespace BlogUniversity.Data
{
    public class SelectionBlog
    {

        public static List<BlogDetailModel> AllBlog;

        public static int pid { get; set; }
        public static List<string>? titles { get; set; }
        public static List<string>? descriptions { get; set; }
        public static List<string>? images { get; set; } 
        public static WriterModel? writer { get; set; } 
        public static DateTime date { get; set; }
        public static string? category { get; set; }
        public static List<CommentModel>? comments;


        public void Reset()
        {
            pid = 0;
            titles = null;
            descriptions = null;
            images = null;
            writer = null;
            date = DateTime.Now;
            category = null;
            comments = null;
        }     
    }

}

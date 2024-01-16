namespace BlogUniversity.Models
{
    public class LayoutData
    {
        public static string statusHome = "hide";
        public static string statusAbout = "hide";
        public static string statusContact = "hide";
        public static string statusPortfolio = "hide";

        public static void ChangeDataTitle(string h, string a , string c ,string p)
        {
            statusHome = h;
            statusAbout = a;
            statusContact = c;
            statusPortfolio = p;
        }
    }
}

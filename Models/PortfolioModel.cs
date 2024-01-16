namespace BlogUniversity.Models
{
    public class PortfolioModel(int id , string wf, string name, string iu , string des , string vid)
    {
        public int Pid = id;
        public string WordFilter = wf;
        public string Name = name;
        public string ImageUri = iu;
        public string Description = des;
        public string VideoUri = vid;
    }
}

using PathfinderIM.Entities.Models.Enums;

namespace PathfinderIM.Entities.Models
{
    public class SourceBook
    {
        public int Id { get; set; } 
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public SourceBookType BookType { get; set; }
        public string Url { get; set; }
    }
}
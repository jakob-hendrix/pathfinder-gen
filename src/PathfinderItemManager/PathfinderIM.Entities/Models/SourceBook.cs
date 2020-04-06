namespace PathfinderIM.Entities.Models
{
    public class SourceBook
    {
        public int Id { get; set; } 
        public string BookName { get; set; }
        public string Url { get; set; }
        public string License { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {BookName}";
        }
    }
}
namespace BookSwaping.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; } = string.Empty;
        public User Owner { get; set; }
    }
}

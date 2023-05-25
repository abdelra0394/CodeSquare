namespace CodeSquare.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? userId { get; set; }
        public DateTime postedAt { get; set; }

        public IList<Likes>? likes { get; set; }

    }
}

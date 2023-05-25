namespace CodeSquare.Models
{
    public class Likes
    {
        public int PostId { get; set; }
        public Post? posts { get; set; }

        public int UserId { get; set; }
        public User? users { get; set; }



    }
}

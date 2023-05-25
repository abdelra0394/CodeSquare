namespace CodeSquare.Models
{
    public class Likes
    {
        public int PostId { get; set; }
        public Posts? posts { get; set; }

        public int UserId { get; set; }
        public Users? users { get; set; }



    }
}

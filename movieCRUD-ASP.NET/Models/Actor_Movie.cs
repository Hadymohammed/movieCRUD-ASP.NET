using System.ComponentModel.DataAnnotations.Schema;

namespace movieCRUD_ASP.NET.Models
{
    public class Actor_Movie
    {
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
        public int MoiveId { get; set; }
        [ForeignKey("MoiveId")]
        public Movie Movie { get; set; }
    }
}

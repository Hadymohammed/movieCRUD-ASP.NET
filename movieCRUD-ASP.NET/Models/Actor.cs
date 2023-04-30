using System.ComponentModel.DataAnnotations;

namespace movieCRUD_ASP.NET.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public string profilePicUrl { get; set; }
        public string Bio { get; set; }
        //relations
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace movieCRUD_ASP.NET.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Bio { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

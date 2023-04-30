using System.ComponentModel.DataAnnotations;

namespace movieCRUD_ASP.NET.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }   
        public string profilePicUrl { get; set; }
        public string Bio { get; set; }
        //Relations
        public List<Movie> Movies { get; set; }
    }
}

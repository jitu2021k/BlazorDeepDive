using System.ComponentModel.DataAnnotations;

namespace ServerMamnagement.Models
{
    public class Server
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        public bool IsOnline { get; set; } = false;
    }
}

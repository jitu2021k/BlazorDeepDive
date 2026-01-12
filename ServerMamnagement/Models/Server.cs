namespace ServerMamnagement.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public bool IsOnline { get; set; } = false;
    }
}

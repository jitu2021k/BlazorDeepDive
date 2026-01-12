namespace ServerMamnagement.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public  bool IsCompleted { get; set; }
        public string TaskName { get; set; } = string.Empty;
    }
}

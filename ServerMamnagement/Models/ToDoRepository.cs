namespace ServerMamnagement.Models
{
    public static class ToDoRepository
    {
        public static List<ToDoTask> GetAllTask()
        {
            return new List<ToDoTask>()
                    { 
                                new ToDoTask {Id = 1, TaskName ="Task1",IsCompleted=false},
                                new ToDoTask {Id = 2, TaskName ="Task2",IsCompleted=false},
                                new ToDoTask {Id = 3, TaskName ="Task3",IsCompleted=false}, 
                                new ToDoTask { Id = 4,TaskName ="Task4",IsCompleted=false}, 
                                new ToDoTask {Id = 5, TaskName ="Task5",IsCompleted=false}, 
                    }; 
        }
    }
}

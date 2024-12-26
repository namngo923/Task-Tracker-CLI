using System;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Assigner {  get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsCompleted { get; set; }
        public override string ToString()
        {
            return $"Task #{Id}\n" +
                   $"Title: {Title}\n" +
                   $"Description: {Description ?? "N/A"}\n" +
                   $"Assigner: {Assigner ?? "Unassigned"}\n" +
                   $"Created At: {CreatedAt:G}\n" +
                   $"Status: {(IsCompleted ? "Completed" : "Pending")}";
        }
    }

    public class TaskItemAdd
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Assigner { get; set; }
        public bool IsCompleted { get; set; }

    }
}

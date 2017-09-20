using System;

namespace AspNetCoreTodo.Models
{
    // This is a POCO (Plain Old C# Object)
    // and there are no assumptions on what the underlying database is
    public class TodoItem
    {
        //globally unique identifier
        public Guid Id { get; set; }

        public bool IsDone { get; set; }

        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}

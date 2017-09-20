// this one is to use IEnumerable
using System.Collections.Generic; 

namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        // that's an array of todoItems
        public IEnumerable<TodoItem> Items { get; set; }
    }
}

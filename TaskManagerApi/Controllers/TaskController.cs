using Microsoft.AspNetCore.Mvc;
using TaskManagerApi.Models;

namespace TaskManagerApi.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        // In-memory storage (no database required)
        private static List<TaskItem> _tasks = new List<TaskItem>();

        // GET /api/tasks - Get all tasks
        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> GetTasks()
        {
            return Ok(_tasks);
        }

        // POST /api/tasks - Create a new task
        [HttpPost]
        public ActionResult<TaskItem> CreateTask([FromBody] TaskItem task)
        {
            if (string.IsNullOrWhiteSpace(task.Description))
            {
                return BadRequest("Description is required");
            }

            // Ensure a new GUID is assigned
            task.Id = Guid.NewGuid();
            task.IsCompleted = false;

            _tasks.Add(task);
            return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
        }

        // PUT /api/tasks/{id} - Update a task
        [HttpPut("{id}")]
        public ActionResult<TaskItem> UpdateTask(Guid id, [FromBody] TaskItem updatedTask)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            
            if (task == null)
            {
                return NotFound($"Task with id {id} not found");
            }

            // Update the task properties
            task.Description = updatedTask.Description;
            task.IsCompleted = updatedTask.IsCompleted;

            return Ok(task);
        }

        // DELETE /api/tasks/{id} - Delete a task
        [HttpDelete("{id}")]
        public ActionResult DeleteTask(Guid id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            
            if (task == null)
            {
                return NotFound($"Task with id {id} not found");
            }

            _tasks.Remove(task);
            return NoContent();
        }
    }
}
using DecouplingSample.Models;

namespace DecouplingSample.Services
{
    public class TodoService : ITodoService
    {
        private ITodoItemRepository _todoItemRepository { get; set; }
        public TodoService(ITodoItemRepository todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }
        public bool Create(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public TodoItem ReadSingle(int id)
        {
            return _todoItemRepository.GetById(id);
        }
    }
}

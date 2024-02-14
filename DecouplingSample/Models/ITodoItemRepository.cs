namespace DecouplingSample.Models
{
    public interface ITodoItemRepository
    {

        public TodoItem GetById(int id);
        public bool Insert(TodoItem item);

    }
}

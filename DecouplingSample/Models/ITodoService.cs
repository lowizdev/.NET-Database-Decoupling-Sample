namespace DecouplingSample.Models
{
    public interface ITodoService
    {
        public TodoItem ReadSingle(int id);
        public bool Create(TodoItem item);
    }
}

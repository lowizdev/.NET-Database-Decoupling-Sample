using DecouplingSample.Models;
using Dapper;

namespace DecouplingSample.Infra
{
    public class TodoItemSQLiteRepository : ITodoItemRepository
    {
        private readonly SQLiteDbSession _sqliteDbSession;
        public TodoItemSQLiteRepository(SQLiteDbSession sqliteDbSession)
        {
            _sqliteDbSession = sqliteDbSession;
        }
        public TodoItem GetById(int id)
        {
            return _sqliteDbSession.DbConnection
                .QueryFirst<TodoItem>("SELECT * FROM todoitem WHERE id = 4" );
        }

        public bool Insert(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}

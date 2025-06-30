namespace AdapterExample
{
    public class UserElements : IElements<User>
    {
        public IEnumerable<User> GetElements()
        {
            return
                [
                new User { Id = 1, Name = "Alice Johnson", Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob Smith", Email = "bob@example.com" },
                new User { Id = 3, Name = "Charlie Lee", Email = "charlie@example.com" }
                ];
        }
    }
}
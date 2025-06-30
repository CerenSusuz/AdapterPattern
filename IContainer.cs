namespace AdapterExample;

public interface IContainer<T>
{
    IEnumerable<T> Items { get; }

    int Count { get; }
}

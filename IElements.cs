namespace AdapterExample;

public interface IElements<T>
{
    IEnumerable<T> GetElements();
}

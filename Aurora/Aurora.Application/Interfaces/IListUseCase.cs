namespace Aurora.Application.Interfaces
{
    public interface IListUseCase<T>
        where T : class
    {
        IEnumerable<T> Execute();
    }
}

namespace Aurora.Application.Interfaces
{
	public interface IUpdateUseCase<T>
		where T : class
	{
		void Execute(T t);
    }
}

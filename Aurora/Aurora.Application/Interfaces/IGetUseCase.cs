namespace Aurora.Application.Interfaces
{
	public interface IGetUseCase<T> where T : class
	{
		T Execute(int id);
	}
}

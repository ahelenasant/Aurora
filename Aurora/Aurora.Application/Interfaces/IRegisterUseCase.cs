namespace Aurora.Application.Interfaces
{
	public interface IRegisterUseCase<T>
		where T : class
	{
		void Execute(T t);
	}
}

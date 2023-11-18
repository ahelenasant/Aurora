namespace Aurora.Domain.Entities
{
	public class User : BaseEntity
	{
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User() { }

		public User(string name, string login, string password, DateTime register, bool status) : base(register, status)
		{
			Name = name;
			Login = login;
			Password = password;
		}
	}
}

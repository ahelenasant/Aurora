using System.ComponentModel.DataAnnotations;

namespace Aurora.Domain.Entities
{
	public class BaseEntity
	{
		[Key]
        public int Id { get; }
		public DateTime Register { get; private set; }
        public bool Status { get; private set; }

        public BaseEntity() { }

		public BaseEntity(DateTime register, bool status)
		{
			Register = register;
			Status = status;
		}

		public void Deactivate()
			=> Status = false;

		public void Activete()
			=> Status = true;
	}
}

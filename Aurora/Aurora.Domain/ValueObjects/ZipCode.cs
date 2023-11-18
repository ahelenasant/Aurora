using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Aurora.Domain.ValueObjects
{
	public struct ZipCode
	{
		private readonly string _value;

		public ZipCode(string value) 
		{
			if (ValidateZipCode(value))
			{
				_value = value;
			}
			else
			{
				throw new ArgumentException("CEP inválido!");
			}
		}

		public bool IsValid
		{
			get { return ValidateZipCode(_value); }
		}

		public bool IsEmpty
			=> (_value != string.Empty);

		private bool ValidateZipCode(string value)
		{
			if (value.Length == 0) return false;

			if (!Regex.IsMatch(_value, @"^\d{5}-\d{3}$")) return false;

			return true;
		}
	}
}

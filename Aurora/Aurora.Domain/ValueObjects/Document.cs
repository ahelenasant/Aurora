namespace Aurora.Domain.ValueObjects
{
	public struct Document
	{
		private readonly string _value;

		public Document(string value)
		{
			if (ValidateCPF(value) || ValidateCNPJ(value))
			{
				_value = value;
			}
			else
			{
				throw new ArgumentException("CPF/CNPJ inválido!");
			}
		}

		public bool IsValid
		{
			get
			{
				return ValidateCPF(_value) && ValidateCNPJ(_value);
			}
		}

        public bool IsEmpty
			=> (_value != string.Empty);

		private bool ValidateCPF(string value)
		{
			value = new string(value.ToCharArray().Where(char.IsDigit).ToArray());

			// Valida o tamanho
			if (value.Length != 11) return false;

			// Calcula o primeiro dígito verificador
			var total = 0;

			for (var i = 0; i < 9; i++)
			{
				total += (value[i] - '0') * (10 - i);
			}

			var digito1 = (total % 11) > 1 ? 11 - (total % 11) : 0;

			// Verifica o primeiro dígito verificador
			if (digito1 != value[9] - '0') return false; 

			// Calcula o segundo dígito verificador
			total = 0;

			for (var i = 0; i < 10; i++)
			{
				total += (value[i] - '0') * (11 - i);
			}

			var digito2 = (total % 11) > 1 ? 11 - (total % 11) : 0;

			// Verifica o segundo dígito verificador
			if (digito2 != value[10] - '0') return false; 

			// Se passou por todas as verificações, o CPF é válido
			return true;
		}

		private bool ValidateCNPJ(string value)
		{
			// Remove caracteres não numéricos do CNPJ
			value = new string(value.Where(char.IsDigit).ToArray());

			// Verifica se o CNPJ tem 14 dígitos
			if (value.Length != 14)
			{
				return false;
			}

			// Calcula o primeiro dígito verificador
			var total = 0;
			int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

			for (var i = 0; i < 12; i++)
			{
				total += (value[i] - '0') * multiplicadores1[i];
			}

			var digito1 = (total % 11) < 2 ? 0 : 11 - (total % 11);

			// Verifica o primeiro dígito verificador
			if (digito1 != value[12] - '0') return false; 

			// Calcula o segundo dígito verificador
			total = 0;
			int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

			for (var i = 0; i < 13; i++)
			{
				total += (value[i] - '0') * multiplicadores2[i];
			}

			var digito2 = (total % 11) < 2 ? 0 : 11 - (total % 11);

			// Verifica o segundo dígito verificador
			if (digito2 != value[13] - '0') return false; 

			// Se passou por todas as verificações, o CNPJ é válido
			return true;
		}
	}
}

namespace PracticaOPP
{
	public abstract class Persona
	{
		public string Nombre { get; set; }
		public string Ciudad { get; set; }
		public int Edad { get; set; }

		public abstract void Registrar();
		public abstract void MostrarDatos();

		public int CalcularEdad(DateTime FechaNacimiento)
		{
			Edad = DateTime.Now.Year - FechaNacimiento.Year;
			return Edad;
		}
	}
}

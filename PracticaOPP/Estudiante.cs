namespace PracticaOPP
{
	public class Estudiante : Persona
	{
		public string Carrera { get; set; }
		public int Matricula { get; set; }
		public DateTime FechaNacimiento { get; set; }


		public override void Registrar()
		{
			Console.WriteLine("Ingrese el nombre del Estudiante:");
			Nombre = Console.ReadLine();

			Console.WriteLine("Ingrese la fecha de nacimiento del Estudiante (yyyy-MM-dd):");
			FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
			int Edad = CalcularEdad(FechaNacimiento);
			this.Edad = Edad;

			Console.WriteLine("¿Cuál es la ciudad en la que reside?");
			Ciudad = Console.ReadLine();

			Console.WriteLine("Ingrese la matrícula del Estudiante:");
			Matricula = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese la carrera del Estudiante:");
			Carrera = Console.ReadLine();


		}

		public override void MostrarDatos()
		{
			Console.WriteLine($"EL estudiante se llama: {Nombre}");
			Console.WriteLine($"Su edad es: {Edad} años");
			Console.WriteLine($"Su matricula es: {Matricula}");
			Console.WriteLine($"La carrera que cursa es: {Carrera}");
			Console.ReadKey();

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOPP
{
	 class Circulo : Figura
	{
		public double Radio { get; set; }

		

		public override double calcularArea()
		{
			return Math.PI * (Radio * Radio);
		}
		public override void RegistrarFigura()
		{
			Console.WriteLine("Ingrese el radio del círculo:");
			Radio = Convert.ToDouble(Console.ReadLine());

		}
		public override void MostrarResultado()
		{
			Console.WriteLine($"Área del circulo: {calcularArea()}");
		}
	}
}

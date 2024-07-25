using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOPP
{
	class Triangulo : Figura
	{
		public double Base { get; set; }	
		public double Altura { get; set; }	


		public override double calcularArea()
		{
			return (Base * Altura) / 2;
		}
		public override void RegistrarFigura()
		{
			Console.WriteLine("Ingrese la base del triángulo:");
			Base = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la altura del triángulo:");
			Altura = Convert.ToDouble(Console.ReadLine());

		}
		public override void MostrarResultado()
		{
			Console.WriteLine($"Área del triangulo: {calcularArea()}");
		}
	}
}

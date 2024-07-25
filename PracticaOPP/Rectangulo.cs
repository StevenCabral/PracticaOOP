using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOPP
{
	 class Rectangulo : Figura
	{
		public double Ancho { get; set; }	
		public double Alto { get; set; }	

		

		public override double calcularArea()
		{
			return Alto * Ancho;
		}

		public override void RegistrarFigura()
		{
			Console.WriteLine("Ingrese el ancho del rectángulo:");
			Ancho = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese el alto del rectángulo:");
			Alto = Convert.ToDouble(Console.ReadLine());
		}
		public override void MostrarResultado()
		{
			Console.WriteLine($"Área del rectángulo: {calcularArea()}");
		}
	}
}

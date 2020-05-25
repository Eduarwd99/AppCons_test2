using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCons_test2
{
	static class Program
	{
		/// Punto de entrada principal para la aplicación.
		[STAThread]
		static void Main()
		{
			//Estructura Secuencial

			int a; a = 10;
			int b; b= 20;
			Console.WriteLine("El producto de {0} X {1} es: {2}" a,b,(a*b));
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();

			//Condicionales

			if (a > b)
			{
				Console.WriteLine("{0} es mayor", a);
			}
			else
			{
				Console.WriteLine("{0} es mayor", b);
			}

			//Bucles
			//Bucle for

			for (int i = 1; i <= 10; i++) ;
			{
				Console.WriteLine("Hola {0}", i);
			}
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();


		}
	}
}

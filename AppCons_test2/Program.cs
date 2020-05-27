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
			int a; a = 10;
			int b; b= 20;
			Console.WriteLine("El producto de {0} X {1} es: {2}",a,b,(a*b));
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
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();

			//Bucle While
			int j = 1;
			while (j <= 10)
			{
				j++;
				Console.WriteLine("{0} Bienvenidos a Git", j);
			}
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();

			//Agregar el bucle for (commit-sincronizar)
			for (int i = 1; i <= 10; i++)
            {
				Console.WriteLine("{0} Bienvenidos a Git", i);
			}
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();

			//Agregar bucle foreach (commit-sincronizar)
			var numeros = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
			int contador = 0;
			foreach (int element in numeros)
			{
				contador++;
				Console.WriteLine($"Element #{contador}: {element}");
			}
			Console.WriteLine($"Number of elements: {contador}");
			Console.WriteLine("Pulse una tecla para continuar...");
			Console.ReadKey();

			//Desde repositorio remoto como compartir su proyecto con el decente
			//kleberposligua@hotmail.com 
			//Crar Manual de GitHub
		}
	}
}

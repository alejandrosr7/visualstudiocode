using System;

namespace CodigoFacilitoTutorial
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			clsEmpleados clsEmpleado = new clsEmpleados();

			clsEmpleado.Edad = 24;
			clsEmpleado.Nombre = "Alejandro Serna Rodriguez";
			clsEmpleado.SueldoMensual = 25.550m;

			Console.WriteLine("El sueldo total es de: {0}", salarioTotal(clsEmpleado, diasTrabajados()));
			Console.ReadKey();

			/*Console.WriteLine("ingresa el primer número: ");
			int numero1 = obtenerNumero();
			Console.WriteLine("Ingresa el segundo número: ");
			int numero2 = obtenerNumero();
			compararNumeros(numero1, numero2);*/
		}

		static int diasTrabajados()
		{
			Console.WriteLine("Ingresa el número de días trabajados");
			return Convert.ToInt32(Console.ReadLine());
		}

		static decimal salarioTotal(clsEmpleados empleado, int dias)
		{
			return empleado.calculaSalario(dias);
		}

		static void compararNumeros(int number1, int number2)
		{
			if (number1 > number2)
			{
				Console.WriteLine("El primer número es mayor");
			}
			else
			{
				Console.WriteLine("El segundo número es mayor");
			}
		}

		static int obtenerNumero(){
			return Convert.ToInt32(Console.ReadLine());
		}
}
}

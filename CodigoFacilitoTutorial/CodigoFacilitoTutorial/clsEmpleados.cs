using System;
namespace CodigoFacilitoTutorial
{
	public class clsEmpleados
	{

		public clsEmpleados(){
			Nombre = "";
			SueldoMensual = 0.0m;
			Edad = 0;
		}
		private string _Nombre;
		private decimal _SueldoMensual;
		private int _Edad;

		public string Nombre
		{
			get
			{
				return _Nombre;
			}

			set
			{
				_Nombre = value;
			}
		}

		public decimal SueldoMensual
		{
			get
			{
				return _SueldoMensual;
			}

			set
			{
				_SueldoMensual = value;
			}
		}

		public int Edad
		{
			get
			{
				return _Edad;
			}

			set
			{
				_Edad = value;
			}
		}

		public decimal calculaSalario(int numeroDias) {
			
			return SueldoMensual * numeroDias;
		}
	}
}


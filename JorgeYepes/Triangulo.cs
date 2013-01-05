using System;
namespace JorgeYepes
{
	public class Triangulo:TFigura//aplicando la herencia
	{
		private float Base,altura;
		
		public Triangulo ()
		{
			Base = 0;
			altura = 0;
		}
		
		public float L1{
			
			get{
				return Base;
			}
			set{
				Base = value;
			}
			
		}
		
		public float L2{
			
			get{
				return altura;
			}
			set{
				altura = value;
			}
			
		}
		
		
		public override float area ()  //metodos son sobre escritos (herencia y polimorfismo)
		{
			return L1*L2/2;
		}
		
		public override float perimetro ()
		{
			return L1 + L2;
		}
		
		
	}
}


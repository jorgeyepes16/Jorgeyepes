using System;

namespace JorgeYepes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TRegistro r = new TRegistro();

			//llamado de metodos (mensajes que apareceran en consola)

			r.LlenarMatrices();
			
			Console.WriteLine("LA MATRIZ DE PERSONAS ES:"); 
			
			for(int i=0; i<3; i++){  
				
				for(int j=0; j<3; j++){
					
					Console.Write(r.Nombres[i,j] + "\t"); 
					
				}
				Console.WriteLine("\n");
			}
			
			Console.WriteLine("\nLA MATRIZ DE NOTAS ES:");
			
			for(int i=0; i<3; i++){
				
				for(int j=0; j<3; j++){
					
					Console.Write(r.Notas[i,j] + "\t");
					
				}
				Console.WriteLine("\n");
			}
			
			Console.WriteLine("\nEL PROMEDIO DE LAS NOTAS ES DE: " + r.PromedioNotas()); //muestra el promedio de las notas ingresadas
			
			Console.WriteLine("\nLA CANTIDAD DE ESTUDIANTES REPROBADOS ES: " + r.ContarPerdidos()); //muestra la cantidad de estudiantes que reprobados (perdidos)
			
			Console.WriteLine("\nLOS ESTUDIANTES REPROBADOS SON: " + r.Perdidos());
			
			
			Console.WriteLine();
			
			Console.WriteLine("***********************************************************************");
			
			Console.WriteLine("\t \t BIENVENIDOS A CHEFWALTER"); // enumeraciones 
						
			Console.WriteLine("***********************************************************************");
			
			Console.WriteLine("TENEMOS A LA VENTA\n");
			
			Console.ForegroundColor = ConsoleColor.Red;
			
			Console.WriteLine("\t CHORIZO \t HAMBURGUESA \t PIZZA" + "\n");
			
			Console.WriteLine("\t PICADA \t LLANERA \t PERRO");
			
			Console.WriteLine("\n¿Que desea Ordenar Madam ?");
			
			string pedido = Console.ReadLine();
			
			pedido = pedido.ToLower(); /// validamos el uso de minusculas y minuculas
			
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.Gray; //color de letra
			
			r.Comprar(pedido);
			
			Triangulo t = new Triangulo();
			
			Console.WriteLine("----------------------------------------------------------------"); // mensajes de la clase Ttriangulo
			
			Console.WriteLine("\nIngrese la base del Triangulo");
			
			t.L1 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("\nIngrese la altura del Triangulo");
			
			t.L2 = float.Parse(Console.ReadLine());
			
			Console.WriteLine("\nEl Area del Triangulo es: " + t.area());
			
			Console.WriteLine("\nEl Perimetro del Triangulo es: " + t.perimetro());
			
			Console.ReadLine();
			
		}
	}
}


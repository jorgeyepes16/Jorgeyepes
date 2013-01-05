using System;
namespace JorgeYepes
{
	public class TRegistro
	{
		
		string [,] nombres; //Declaramos la matriz "nombres" de tipo string (matriz multidimensional) esta matriz guardara los nombres de los estudiantes
		float [,] notas;    //Declaramos la matriz "notas" de tipo float (matriz multidimensional) esta matriz guardara las notas de cada estudaintes
		
		public TRegistro ()
		{			
			nombres = null; // inicializamos la matriz en vacio; tanto la matriz "nombres" como la matriz notas
			notas = null;
			
		}

		//campos propiedades (metodos set y get)
		public string [,] Nombres{
			
			get{
				return nombres;
			}
			set{
				nombres= value;
			}
		}
		
		public float [,] Notas{
			
			get{
				return notas;
			}
			set{
				notas= value;
			}
		}


		//Metodo de llenado de las matrices. en este caso damos damos tamaño a las matrices (3x3) 

		public void LlenarMatrices(){
			
			Nombres = new string[3,3];
			Notas = new float[3,3];
			
			for(int i=3; i>0; i--){ //utilizamos un ciclo for para recorrer la matriz y lo hacemos utilizando oepradores de decremento (estamos llenando la matriz de atras hacia delante)
				
				for(int j=3; j>0; j--){
					
					Console.WriteLine("Ingrese el estudiante de la posicion [" + (i-1) + "," + (j-1) + "]"); /// mensaje que imprimara la consola al ingresael nombre de un estudiante
					Nombres[i-1,j-1]=(Console.ReadLine());
					
					Console.WriteLine();
					
					Console.WriteLine("Ingrese la Nota del estudiante de la posicion [" + (i-1) + "," + (j-1) + "]"); //mensaje que imprimira la consola al ingresar la nota de un estudiante
					Notas[i-1,j-1]= Convert.ToSingle(Console.ReadLine());
					
					Console.WriteLine();
					
				}
				
				
			}
			
			
		}

		//Metodo que calcula el promedio de las notas de los estudiantes
		
		public float PromedioNotas(){
			
			float suma = 0;
			int i=0;
			int j=0;
			float prom;
			
			while(i<3){
				
				while(j<3){
					
					suma = suma + Notas[i,j];
									
					j++;	
				}	
				
				i++;
				j=0;
			}
			
			prom = suma/9;
			return prom;
		}
		//metodo que cuenta cuantos estudiantes reprobaron 
		
		public int ContarPerdidos(){
			
			int cont=0;
			
			int i=0;
			int j=0;
						
			while(i<3){
				
				while(j<3){
					
					if(Notas[i,j] < 3){
						cont = cont+1;
					}			
					j++;
				}	
				
				i++;
				j=0;
			}
			
			
			return cont;
		}

		//metodo que muestra los estudiantes reprobados 

		public string Perdidos(){
			
			string nom = "";
			
			int i=0;
			int j=0;
						
			while(i<3){
				
				while(j<3){
					
					if(Notas[i,j] < 3){
						nom = nom + Nombres[i,j] + ",";
					}			
					j++;
				}	
				
				i++;
				j=0;
			}
			
			
			return nom;
		}
		// Enumeracion
		public enum ChefWalter{
			
			pizza=2000, chorizo=1800, picada=3000, ///enumeraciones (no soportan variables tipo cadena)
			
			perro = 2500, llanera=8500, hamburguesa=4000 
			
		}
		
		public void Comprar(string orden){  /// asignamos el pedido deacuerdo a un parametro  (listas que guardan datos constantes)
			
			if(orden=="pizza")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.pizza);  // convertimos a entero  (perceamos el dato)
			
			if(orden=="chorizo")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.chorizo);
			
			if(orden=="picada")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.picada);
			
			if(orden=="perro")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.perro);
			
			if(orden=="llanera")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.llanera);
			
			if(orden=="hamburguesa")
				Console.WriteLine("EL MONTO A PAGAR EN CAJA ES $" + (int)ChefWalter.hamburguesa);
			
		}
		
		
		
		
		
		
		
		
		
		
		
		
	}
}


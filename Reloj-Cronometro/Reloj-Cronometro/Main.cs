using System;

namespace RelojCronometro
{
	class Principal
	{
		public static void Main (string[] args)
		{
			Reloj r;
			Cronometro c;
			
			Console.WriteLine ("Menu");
			Console.WriteLine("1- Reloj");
			Console.WriteLine("2- Cronometro");
			Console.WriteLine("Eliga una opcion");
			
				string p = Console.ReadLine();
					int op = int.Parse(p);
					
						switch(op){
				
							case 1:
									r= new Reloj();
									r.GetHashCode();
							break;
							
							case 2:
									c = new Cronometro();
									c.GetHashCode();
							break;
							
							case 3:
									Console.WriteLine("Opcion NO VALIDA");
							break;
			}
		}
	}
}

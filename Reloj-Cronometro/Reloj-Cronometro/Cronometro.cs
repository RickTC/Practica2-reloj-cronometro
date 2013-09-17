using System;

namespace RelojCronometro
{
	public class Cronometro
	{
		public Cronometro ()
		{
			int h,m,s;
			
				for(h=0; h<100; h++){
					for(m=0; m<60; m++){
						for(s=0; s<60; s++){
							
							Console.WriteLine(h +":"+ m +":"+ s);
							System.Threading.Thread.Sleep(1000);
							Console.Clear();
					}
				} 
			}
		}
	}
}


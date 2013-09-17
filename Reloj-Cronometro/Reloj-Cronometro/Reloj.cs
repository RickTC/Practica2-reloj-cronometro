using System;

namespace RelojCronometro
{
	public class Reloj
	{
		public Reloj ()
		{
			
			int h= DateTime.Now.Hour;
			int m= DateTime.Now.Minute;
			int s= DateTime.Now.Second;
				
				for(int ho=h; ho<24; ho++){
					for(int mi=m; mi<60; mi++){
						for(int se=s; se<60; se++){
							
						Console.Clear();
						Console.WriteLine (ho +":"+mi+":"+ se);
						System.Threading.Thread.Sleep (1000);
						
					}
				}	
			 }
		}
	}
}


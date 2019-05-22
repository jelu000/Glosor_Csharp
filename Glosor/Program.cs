/* 
 * Created by SharpDevelop.
 * User: jens lundeqvist
 * Date: 2019-05-18
 * Time: 15:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Glosor
{
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			
			
			List<Glosa> alla_glosor = new List<Glosa>();
			string mata_in = "j";
			int i = 0;
			string filnamn = "sparadeglosor.txt";
			
			
			
			// TODO: Implement Functionality Here
			Console.WriteLine(".:Glosor:.\n");
			Console.WriteLine("Vill du mata in nya glosor tryck 1, vill du läsa in fil med glosor tryck 2.\n");
			string programval_1 = Console.ReadLine();//användarens vall att mata in nya glosor eller läsa in dem från fil
			
			if (programval_1 == "1"){
				while (mata_in != "n"){
					Glosa t_glosa = new Glosa();
					
					Console.WriteLine("\nMata in svensk glosa: ");
					t_glosa.setSveGlosa(Console.ReadLine());
					
					Console.WriteLine("Mata in engelsk glosa: ");
					t_glosa.setEngGlosa(Console.ReadLine());
					
					alla_glosor.Add(t_glosa);
					
					Console.WriteLine("\nVill du mata in en glosa till j/n ? ");
					mata_in = Console.ReadLine();
				}
			}
			
			else if (programval_1 == "2"){
				GlosFilehandler gfilehandler = new GlosFilehandler();
				alla_glosor = gfilehandler.readGlosor(filnamn);
			}
			
				
			mata_in = "j";
			
			while (mata_in != "n"){
				
				Console.Clear();
				Console.WriteLine("\nNu startar glostestet!\n");
				
				int antal_ratt = 0;
				
				
				for (i=0; i<alla_glosor.Count; i++){
					
					Glosa t_glosa = (Glosa)alla_glosor[i];
					Console.WriteLine(t_glosa.SveGlosa);
					
					string t_svar = Console.ReadLine();
					
					if (t_glosa.EngGlosa == t_svar){
						Console.WriteLine("Korrekt!\n");
						antal_ratt++;
					}
					
					else
						Console.WriteLine("Fel! Rätt svar är: " + t_glosa.EngGlosa + "\n");
										
					
				}
				
				if (alla_glosor.Count == antal_ratt)
					Console.WriteLine("Grattis! Du hade alla rätt.\n");
					
				else
					Console.WriteLine("Du hade " + antal_ratt + " av " + alla_glosor.Count + " möjliga rätt.\n");
				
				
				Console.WriteLine("Vill du göra om glostetstet? j/n");
				
				
				mata_in = Console.ReadLine();
						
			}
			
			
			mata_in = "n";
			Console.WriteLine("Vill du spara dessa glosor till nästa gång du startar programmet? j/n");
			mata_in = Console.ReadLine();
			
			
			if (mata_in == "j"){
				GlosFilehandler gfilehandler = new GlosFilehandler();
				gfilehandler.saveGlosor(filnamn, alla_glosor);
			}
				
			//Console.ReadKey(true);
		}
	}
}
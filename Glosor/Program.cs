/*
 * Created by SharpDevelop.
 * User: jens
 * Date: 2019-05-18
 * Time: 15:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Glosor
{
	class Program
	{
		
		
		public static void Main(string[] args)
		{
			
			
			
			
			
			ArrayList alla_glosor = new ArrayList();
			string mata_in = "j";
			int i = 0;
			string temp_glosa;
			
			
			// TODO: Implement Functionality Here
			Console.WriteLine(".:Glosor:.");
			
			while (mata_in != "n"){
				Glosa t_glosa = new Glosa();
				
				Console.WriteLine("Mata in svensk glosa: ");
				t_glosa.setSveGlosa(Console.ReadLine());
				
				Console.WriteLine("Mata in engelsk glosa: ");
				t_glosa.setEngGlosa(Console.ReadLine());
				
				alla_glosor.Add(t_glosa);
				
				Console.WriteLine(ValueType"Vill du mata in en glosa till j/n? ");
				mata_in = Console.ReadLine();
				
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
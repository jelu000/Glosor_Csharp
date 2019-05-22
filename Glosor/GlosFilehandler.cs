/*
 * Created by SharpDevelop.
 * User: jens Lundeqvist
 * Date: 2019-05-19
 * Time: 21:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;


namespace Glosor
{
	/// <summary>
	/// Description of GlosFilehandler.
	/// </summary>
	public class GlosFilehandler
	{
		public GlosFilehandler()
		{
		}
		
		public GlosFilehandler(string tfilename)
		{
			//Path.Combine(AppDomain.CurrentDomain.BaseDirectory, t_filename);
		}
		
		public void saveGlosor(string t_filename, List<Glosa> t_glosarray){
			
			using (TextWriter t_writer = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, t_filename))){
				
				foreach (var glosa in t_glosarray){
					t_writer.WriteLine(string.Format("sve_glosa: {0} - eng_glosa {1}", glosa.SveGlosa, glosa.EngGlosa));
				}
			
			}
		}
		
		public List<Glosa> readGlosor(string t_filename){
			
            List<Glosa> t_glosor = new List<Glosa>();
            string t_filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "\\" + t_filename);
            String[] lines = System.IO.File.ReadAllLines(t_filepath);
			                                 
			// Display the file contents by using a foreach loop.
        	//System.Console.WriteLine("filepath: " + t_filepath);
        	foreach (String t_string in lines)
        	{
        		Glosa t_glosa = new Glosa();
        		
        		
        		string[] t_glos_elements = t_string.Split(new String[] {"- eng_glosa "}, StringSplitOptions.RemoveEmptyEntries);
        		string t_svenskglosa = t_glos_elements[0];
     			
     			string[] t_glos_elements2 = t_svenskglosa.Split(new String[] {"sve_glosa: "}, StringSplitOptions.RemoveEmptyEntries);
     			
        		t_glosa.SveGlosa = t_glos_elements2[0];
        		t_glosa.EngGlosa = t_glos_elements[1];
        		
        		t_glosor.Add(t_glosa);
        		
        	}   
        	
        	return t_glosor;
		}
		
	}
}
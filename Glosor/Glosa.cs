/*
 * Created by SharpDevelop.
 * User: jens lundeqvist
 * Date: 2019-05-18
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Glosor
{
	/// <summary>
	/// Description of Glosa.
	/// </summary>
	public class Glosa
	{
		private string sve_glosa;
		private string eng_glosa;
		//private String sve_glosa, eng_glosa; //have to import System namespace
		
		
		//Constructors
		public Glosa()
		{
			sve_glosa = "";
			eng_glosa = "";
		}
		
		public Glosa(string tsve_glosa, string teng_glosa){
			sve_glosa = tsve_glosa;
			eng_glosa = teng_glosa;
		}
		
		//setters
		public void setGlosa(string tsve_glosa, string teng_glosa){
			sve_glosa = tsve_glosa;
			eng_glosa = teng_glosa;
		}
		
		public void setSveGlosa(string tsve_glosa){
			sve_glosa = tsve_glosa;
		}
		
		public void setEngGlosa(string teng_glosa){
			eng_glosa = teng_glosa;
		}
		
		
		//getters
		public string getSveGlosa(){
			return sve_glosa;
		}
		
		public string getEngGlosa(){
			return eng_glosa;
		}
		
		//Own Variables, different way to asign variables to this Object 
		public string SveGlosa{
			get { return sve_glosa; }
			set { sve_glosa = value; }
		}
		
		public string EngGlosa{
			get { return eng_glosa; }
			set { eng_glosa = value; }
		}
	}
}

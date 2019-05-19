/*
 * Created by SharpDevelop.
 * User: jens
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
		
		//getters
		public string getSveGlosa(){
			return sve_glosa;
		}
		
		public string getEngGlosa(){
			return eng_glosa;
		}
		
	}
}

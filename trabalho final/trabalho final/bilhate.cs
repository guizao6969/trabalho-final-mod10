/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 21/11/2023
 * Time: 15:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace trabalho_final
{
	/// <summary>
	/// Description of bilhate.
	/// </summary>
	public abstract class bilhate
	{
		public int quantidadee;
		
		public int Quantidadee{
			set{quantidadee=value;}
			get {return quantidadee;}
		}
		
		public bilhate()
		{
		}
		~bilhate()
		{
		}
	}
}

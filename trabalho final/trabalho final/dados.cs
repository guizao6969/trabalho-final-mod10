/*
 * Created by SharpDevelop.
 * User: guies
 * Date: 20/11/2023
 * Time: 23:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace trabalho_final
{
	/// <summary>
	/// Description of dados.
	/// </summary>
	public class dados
	{
		protected string nome, tamanho, pais, morada, msg, distrito;
		private int quantidade, numero, codig;
		
		public string Nome{
		set {nome=value;}
 		get{return nome;}
		}

		public int Quantidade{
			set{quantidade=value;}
			get {return quantidade;}
		}

		public string Tamanho{
		set { tamanho=value;}
		get {return tamanho;}
		}	
		public int Numero{
		set { numero=value;}
		get {return numero;}
		}	
		public string Pais{
		set { pais=value;}
		get {return pais;}
		}	
		public string Morada{
		set { morada=value;}
		get {return morada;}
		}	
		public int Codig{
		set { codig=value;}
		get {return codig;}
		}	
		public string Distrito{
		set {distrito=value;}
 		get{return distrito;}
		}
		
		public string menssagens(){
			msg="Encomenda será entregue com\n\n"+Quantidade+" camisola(s) de tamanho "+Tamanho+"\n"+"\nO número e nome será: "+Nome+" "+Numero+"\n\nSerá em "+Pais+" no distrito de: "+Distrito+" na morada: "+Morada+" código postal: "+Codig;
			return msg;
		}
			
		public dados()
		{
		}
		~dados()
		{
		}
	
	}
}

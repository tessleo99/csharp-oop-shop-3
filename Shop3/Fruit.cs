using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Fruit: Product
	{
		//ATTRIBUTES
		string origin;
		string typeOfFruit;
		bool packed;

		//CONSTRUCTOR
		public Fruit(string name, string description, float price, string categoryName, string origin, string typeOfFruit, int tax = 22, bool packed = false) :base(name, description, price, categoryName, tax)
		{
			this.origin = origin;
			this.typeOfFruit = typeOfFruit;
			this.packed = packed;
		}

		//GETTERS
		public string GetOrigin()
		{
			return origin;
		}

		public string GetTypeOfFruit()
		{
			return typeOfFruit;
		}

		public bool GetPackedInfo()
		{
			return packed;
		}

		//SETTERS
		public bool SetPacked(bool newPacked)
		{
			packed = newPacked;
			return packed;
		}


		public override string ToString()
		{
			string stringa =
			$"Nome: {this.GetName()}, Descrizione: {this.GetDescription()}, Codice: {this.code}, Prezzo: {this.GetPrice().ToString("N2")}€, Categoria: {category.ToString()}, ";
			stringa += $"Type of fruit: {this.typeOfFruit}, Origin: {this.origin} \n";
			return stringa;
		}

		public string ToString(string formato)
		{
			switch (formato)
			{
				case "inline":
					return this.ToString();
					break;
				case "newline":
					string stringa =
						$"Nome: {this.GetName()}\nDescrizione: {this.GetDescription()}\nCodice: {this.code}\nPrezzo: {this.GetPrice().ToString("N2")}€\nCategoria: {category.ToString()}\n";
					stringa += $"Type of fruit: {this.typeOfFruit}\nOrigin: {this.origin}\n";
					return stringa;
					break;
				default:
					return this.ToString();
					
			}

		}

	}
}

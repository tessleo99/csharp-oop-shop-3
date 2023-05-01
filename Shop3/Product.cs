using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Product
	{
		private static int numberOfGeneratedProduct = 0;

		//ATTRIBUTES + PROPERTIES
		private protected string code;
		private string name;
		private string description;
		private float price;
		private int tax;
		private protected Category category;

		//GETTERS
		public static int GetTotalGeneratedProducts()
		{
			return numberOfGeneratedProduct;
		}

		public string GetCode()
		{
			return this.code;
		}

		public string GetName()
		{
			return this.name;
		}

		public string GetDescription()
		{
			return this.description;
		}

		public float GetPrice()
		{
			return this.price;
		}

		public int GetTax()
		{
			return this.tax;
		}

		public Category GetCategory()
		{
			return this.category;
		}

		//SETTERS
		public void SetName(string newName)
		{
			this.name = newName;
		}

		public void SetDescription(string newDescription)
		{
			this.description = newDescription;
		}

		public void SetPrice(float newPrice)
		{
			this.price = newPrice;
		}

		public void SetTax(int newTax)
		{
			this.tax = newTax;
		}

		//CONSTRUCTOR
		public Product(string name, string description, float price, string categoryName, int tax = 22)
		{
			this.name = name;
			this.description = description;
			this.code = getCodePadLeft8();
			this.price = price;
			this.tax = tax;
			this.category = new Category(categoryName);

			numberOfGeneratedProduct++;
		}

		//METHODS
		private string getCodePadLeft8()
		{
			Random rnd = new Random();
			int numeroCifre = rnd.Next(1, 9);

			int codeInt = 0;

			switch (numeroCifre)
			{
				case 1:
					codeInt = rnd.Next(1, 10);
					break;
				case 2:
					codeInt = rnd.Next(10, 100);
					break;
				case 3:
					codeInt = rnd.Next(100, 1000);
					break;
				case 4:
					codeInt = rnd.Next(1000, 10000);
					break;
				case 5:
					codeInt = rnd.Next(10000, 1000000);
					break;
				case 6:
					codeInt = rnd.Next(100000, 1000000);
					break;
				case 7:
					codeInt = rnd.Next(1000000, 10000000);
					break;
				case 8:
					codeInt = rnd.Next(10000000, 100000000);
					break;

			}

			string codeString = codeInt.ToString();
			string codeStringPadded = codeString.PadLeft(8, '0');
			return codeStringPadded;

		}

		public override string ToString()
		{
			string infoProduct =
			$"Nome: {this.name} \n" +
			$"Descrizione: {this.description} \n" +
			$"Codice: {this.code} \n" +
			$"Prezzo: {this.price} \n" +
			$"Categoria: \n" +
			$"{category.ToString()}";

			return infoProduct;
		}

	}
}

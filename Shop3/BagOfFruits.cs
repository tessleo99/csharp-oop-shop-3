using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace csharp_shop_2
{
	public class BagOfFruits: Product
	{
		//ATTRIBUTES
		private string typeOfBag;
		private int maxNumberOfFruits;
		private List<Fruit> fruitsInBag;

		//COSTRUCTOR
		public BagOfFruits(string name, string description, float priceOfBag, string categoryName, string typeOfBag, int maxNumberOfFruits, int tax = 22) : base(name, description, priceOfBag, categoryName, tax)
		{
			this.typeOfBag = typeOfBag;
			this.maxNumberOfFruits = maxNumberOfFruits;
			this.fruitsInBag = new List<Fruit>();
		}

		//GETTERS
		public string GetTypeOfBag()
		{
			return this.typeOfBag;
		}

		public int GetMaxNumberOfFruits()
		{
			return this.maxNumberOfFruits;
		}

		public List<Fruit> getFruitsInBag()
		{
			return this.fruitsInBag;
		}

		//METHODS
		public void AddFruitInBag(Fruit newFruit)
		{
			if (this.fruitsInBag.Count < maxNumberOfFruits)
			{
				this.fruitsInBag.Add(newFruit);
			}
		}

		public void AddListOfFruitInbag(List<Fruit> newFruitList)
		{
			foreach(Fruit newFruitListToAdd in newFruitList)
			{
				this.AddFruitInBag(newFruitListToAdd);
			}
		}

		public override string ToString()
		{
			string stringa = base.ToString();
			stringa += "Type of bag: " + this.typeOfBag + "\n";
			stringa += "Fruits contained: " + "\n";

			foreach(Fruit fruitPicked in this.fruitsInBag)
			{
				stringa += $"\t - {fruitPicked.ToString()} \n";
			}

			return stringa;
		}




	}
}

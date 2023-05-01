using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Water : Product
	{
		//ATTRIBUTES
		private string brand;
		private float maxCapacity;
		private float litersInTheBottle;
		private float pH;
		private string source;

		//CONSTRUCTOR
		public Water(string name, string description, float price, string categoryName, string brand, float maxCapacity, float initialLiters, float pH, string source, int tax = 22) : base(name, description, price, categoryName, tax)
		{
			if (pH < 0 || pH > 10)
			{
				throw new Exception("Il pH scelto non è valido");
			}
				this.brand = brand;
				this.maxCapacity = maxCapacity;
			if (initialLiters > maxCapacity || initialLiters < 0)
			{
				throw new Exception("I litri iniziali scelti non sono validi");
			}
                this.litersInTheBottle = initialLiters;

				this.pH = pH;
				this.source = source;
		
			
		}



		//GETTERS
		
		public string GetBrand()
		{
			return this.brand;
		}

		public float GetMaxCapacity()
		{
			return this.maxCapacity;
		}

		public float GetLitersInBottle()
		{
			return this.litersInTheBottle;
		}

		public float GetpH()
		{
			return this.pH;
		}

		public string getSource()
		{
			return this.source;
		}

		//SETTERS
		public void setBrand(string newBrand)
		{
			this.brand = newBrand;
		}

		//METHODS
		public void Drink(float litersToDrink)
		{
			if (litersToDrink > this.maxCapacity || litersToDrink > litersInTheBottle)
			{
                throw new Exception("Non puoi bere così tanto");
                litersInTheBottle = 0;
            }
			else
			{

                litersInTheBottle -= litersToDrink;
                Console.WriteLine("Ora hai: " + litersInTheBottle + " Litri");

            }
			
		}

		public void Fill(float litersToPutIntoBottle)
		{
			if ((litersToPutIntoBottle + litersInTheBottle) <= this.maxCapacity)
			{
				this.litersInTheBottle += litersToPutIntoBottle;
				Console.WriteLine("Hai aggiunto: " + litersToPutIntoBottle + "L" + " ora ci sono " + this.litersInTheBottle);

			}
			else
			{
                throw new Exception("Non puoi riempire la bottiglia così tanto");
                litersInTheBottle = maxCapacity;
			}
		}

		public void EmptyBottle()
		{
			litersInTheBottle = 0;
		}

		public override string ToString()
		{
			string infoProduct =
			$"Nome: {this.GetName()} \n" +
			$"Marca: {this.brand} \n" +
			$"pH: {this.pH} \n" +
			$"Descrizione: {this.GetDescription()} \n" +
			$"Codice: {this.code} \n" +
			$"Prezzo: {this.GetPrice()} \n" +
			$"Categoria: \n";

			return infoProduct;

		}

       
            public static double LitersToGalleon(float liters)
            {
                float galleon = (liters / 3.785f);
                return galleon;
            }
            
        




	}
}

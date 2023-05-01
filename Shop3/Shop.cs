using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_2
{
	public class Shop
	{
		//ATTRIBUTES
		private string name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}

		}

		private string city;
		public string City
		{
			get
			{
				return this.city;
			}
		}

		private string address;
		public string Address
		{
			get
			{
				return this.address;
			}
		}

		private string houseNumber;
		public string HouseNumber
		{
			get
			{
				return this.houseNumber;
			}
		}

		private List<Product> shopProducts; //LIST
		public List<Product> ShopProducts
		{
			get
			{
				return this.shopProducts;
			}
		}

		//CONSTRUCTOR
		public Shop(string name, string city, string address, string houseNumber)
		{
			this.name = name;
			this.city = city;
			this.address = address;
			this.houseNumber = houseNumber;
			this.shopProducts = new List<Product>();
		}

		//METHOD

		//Add new product to shop list
		public void AddNewProductToShopList(Product newProduct)
		{
			this.shopProducts.Add(newProduct);
		}

		//add new list of products to shop list
		public void AddNewProductListToShopList(List<Product> productList)
		{
			foreach (Product newProductList in productList)
			{
				this.shopProducts.Add(newProductList);
			}
		}

		public int GetTotalProducts()
		{
			return this.ShopProducts.Count;
		}

		//print shop info + products + category
		public override string ToString()
		{
			string shopInfo =
			$"Nome: {this.name} \n" +
			$"Città: {this.city} \n" +
			$"Indirizzo: {this.address} \n" +
			$"Numero civico: {this.houseNumber} \n" +
			$"Prodotti: \n";

			foreach (Product productsInList in shopProducts)
			{
				shopInfo += "-" + productsInList.ToString() + "\n";
			}

			shopInfo += "\n";
			return shopInfo;
		}
	}
}

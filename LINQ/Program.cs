using LINQ.DataSources;
using LINQ.Models;
using static LINQ.DataSources.Source;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region 1
			//var seafoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

			//foreach (var product in seafoodProducts)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
			//}
			#endregion
			#region 2
			//var productNames = Source.ProductList.Select(p => p.ProductName);

			//foreach (var name in productNames)
			//{
			//	Console.WriteLine(name);
			//}
			#endregion
		}
	}
}

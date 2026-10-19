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
			#region 3
			//var sortedProducts = Source.ProductList.OrderBy(p => p.UnitPrice);

			//foreach (var product in sortedProducts)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
			//}
			#endregion
			#region 4
			//var productsInRange = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

			//foreach (var product in productsInRange)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Price: {product.UnitPrice}");
			//}
			#endregion
			#region 5
			//var availableCondiments = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Spices & Condiments");

			//foreach (var product in availableCondiments)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}, Category: {product.Category}");
			//}
			#endregion
			#region 6
			//var productDetails = Source.ProductList.Select(p => new
			//{
			//	Name = p.ProductName,
			//	Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
			//});

			//foreach (var item in productDetails)
			//{
			//	Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
			//}
			#endregion
			#region 7
			//var indexedProducts = Source.ProductList.Select((p, index) => new { Index = index + 1, Name = p.ProductName });

			//foreach (var item in indexedProducts)
			//{
			//	Console.WriteLine($"{item.Index}. {item.Name}");
			//}
			#endregion
			#region 8
			//var sortedProducts = Source.ProductList
			//          .OrderBy(p => p.Category)
			//          .ThenByDescending(p => p.UnitPrice);

			//foreach (var product in sortedProducts)
			//{
			//	Console.WriteLine($"Category: {product.Category}, Name: {product.ProductName}, Price: {product.UnitPrice}");
			//}
			#endregion
			#region 9
			//var beverages = Source.ProductList
			//         .Where(p => p.Category == "Beverages")
			//         .OrderByDescending(p => p.UnitsInStock);

			//foreach (var product in beverages)
			//{
			//	Console.WriteLine($"Name: {product.ProductName}, Stock: {product.UnitsInStock}");
			//}
			#endregion
			#region 10
			//var ordersFrom1997 = from c in Source.CustomerList
			//					 from o in c.Orders
			//					 where o.OrderDate.Year >= 1997
			//					 select new
			//					 {
			//						 c.CustomerID,
			//						 o.OrderDate
			//					 };

			//foreach (var item in ordersFrom1997)
			//{
			//	Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate.ToShortDateString()}");
			//}
			#endregion
			#region 11
			//var indexedProducts = Source.ProductList.Select((p, index) => new { Position = index + 1, Name = p.ProductName });

			//foreach (var item in indexedProducts)
			//{
			//	Console.WriteLine($"Position: {item.Position}, Product Name: {item.Name}");
			//}
			#endregion
			#region 12
			//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			//var sortedWords = Arr
			//	.OrderBy(w => w.Length)
			//	.ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

			//foreach (var word in sortedWords)
			//{
			//	Console.WriteLine(word);
			//}
			#endregion
			#region 13
			//string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			//var result = digits
			//	.Where(d => d.Length > 1 && d[1] == 'i')
			//	.Reverse();

			//foreach (var digit in result)
			//{
			//	Console.WriteLine(digit);
			//}
			#endregion
		}
	}
}

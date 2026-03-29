//using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Part 01

			#region var vs dynamic vs object 

			//var name = "Salma";
			//// name = 99; //compile error — still a string

			//dynamic value = "Hello";
			//value = 42;
			//value = true;
			//value = new Customer();

			//object age = 30;

			//Console.WriteLine(name.GetType());
			//Console.WriteLine(value.GetType());
			//Console.WriteLine(age.GetType());


			//Console.WriteLine(name.Length);
			//Console.WriteLine(value.CompanyName);
			//Console.WriteLine(((string)age).Length);

			#endregion

			#region Query Syntax vs Method Syntax

			//var students = new List<Student>
			//{
			//	new() { Name = "Sara",  Grade = 90, Major = "CS"   },
			//	new() { Name = "Omar",  Grade = 75, Major = "Math" },
			//	new() { Name = "Layla", Grade = 88, Major = "CS"   },
			//	new() { Name = "Karim", Grade = 60, Major = "CS"   },
			//	new() { Name = "Nour",  Grade = 95, Major = "Math" },
			//};
			//// Filter students with grade >= 80 and major in CS,
			//// order by grade descending,
			//// select name and grade

			//var result = from s in students
			//			 where s.Grade >= 80 && s.Major == "CS"
			//			 orderby s.Grade descending
			//			 select new { s.Name, s.Grade };

			//result = students
			//  .Where(s => s.Grade >= 80 && s.Major == "CS")
			//  .OrderByDescending(s => s.Grade)
			//  .Select(s => new { s.Name, s.Grade });

			//foreach (var s in result)
			//	Console.WriteLine($"{s.Name} => {s.Grade}");

			#endregion

			#region Deferred vs Immediate Execution
			//var numbers = new List<int> { 1, 2, 3, 4, 5 };

			////// DEFERRED — query is defined but NOT executed yet
			////var result01 = numbers.Where(n => n % 2 == 0);
			////numbers.Add(6);
			////Console.WriteLine("After Adding 6");
			////foreach (var num in result01)
			////	Console.WriteLine(num); // 2 4 6

			//// IMMEDIATE — executes right away, captures snapshot
			//var result02 = numbers.Where(n => n % 2 == 0).ToList(); // ToList forces execution
			//numbers.Add(6);
			//Console.WriteLine("After Adding 6");
			//foreach (var num in result02)
			//	Console.WriteLine(num); // 2 4 


			#endregion

			#endregion

			#region Part 02

			#region Filtering - Restriction

			#region Where 
			//// Out Of Stock Products 
			//var result = Source.ProductList.Where(p => p.UnitsInStock == 0);
			//var result = ProductList.Where(p => p.UnitsInStock == 0);

			//result = from p in ProductList
			//		 where p.UnitsInStock == 0
			//		 select p;

			//// in stock AND price > $20
			//result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 20m);
			//result = from p in ProductList
			//		 where p.UnitsInStock > 0 & p.UnitPrice > 20
			//		 select p;
			#endregion

			#region Indexed Where 
			////Get Products Out Of Stock In First 20 Product
			//var result = ProductList.Where((p, i) => p.UnitsInStock == 0 && i < 20);
			#endregion

			#region OfType<>

			//ArrayList mixed = new() { 1, "hello", 3.14, "world", true, "linq" };

			//var result = mixed.OfType<string>();

			#endregion

			#endregion

			#region Projection

			#region Select 
			//// product names only
			//var result = ProductList.Select(p => p.ProductName);

			//// {Name, Category, Price}
			//var result = ProductList.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });

			//// indexed overload
			//int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
			//var result = numbers.Select((n, i) => new { Num = n, InPlace = n == i });

			#endregion

			#region SelectMany 

			////var result = Source.CustomerList.Select(c => c.Orders);
			//var result = CustomerList.SelectMany(c => c.Orders);


			//// SelectMany with result selector
			//var result = CustomerList.SelectMany(c => c.Orders, (c, o) => new { c.CustomerID, o.OrderID, o.Total });


			//var result = CustomerList.SelectMany((c, ci) => c.Orders
			//						 .Select(o => $"Customer #{ci + 1} [{c.CustomerID}] =>  Order Id :{o.OrderID}"));

			//var result = CustomerList.SelectMany((c, ci) => c.Orders
			//						 .Select((o, oi) => $"Customer #{ci + 1} [{c.CustomerID}] =>  Order#{oi + 1}  Order Id : {o.OrderID}"));

			//// Query syntax
			//// orders with Total < $500
			//var result = from c in CustomerList
			//			 from o in c.Orders
			//			 where o.Total < 500m
			//			 select new { c.CustomerID, o.OrderID, o.Total };

			#endregion

			#endregion

			#region Ordering
			//// OrderBy(keySelector)
			//var result = ProductList.OrderBy(p => p.ProductName);

			//// OrderBy(keySelector, comparer)
			//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
			//var result02 = words.OrderBy(w => w, new StringCaseInsensitiveComparer());

			//// OrderByDescending
			//result = ProductList.OrderByDescending(p => p.UnitPrice);

			//// OrderByDescending(keySelector, comparer)
			//result02 = words.OrderByDescending(w => w, new StringCaseInsensitiveComparer());

			//// ThenBy(keySelector)
			//result = ProductList.OrderBy(p => p.Category).ThenBy(p => p.ProductName);
			//result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

			//// Reverse()
			//string[] names = { "Aya", "omar", "Amr", "Mohamed", "Ahmed" };
			//var result03 = names.Where(x => x[0] == 'A').Reverse();

			//// Query Syntax 
			//result = from p in ProductList
			//		 orderby p.Category, p.UnitPrice descending
			//		 select p;

			#endregion

			//foreach (var item in result)
			//	Console.WriteLine(item);
			#endregion

		}
	}
}

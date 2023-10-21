using System.Reflection;

namespace Reflections
{
	public class Program
	{
		static void Main(string[] args)
		{
			Type t = Type.GetType("Reflections.Customer");
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            

            PropertyInfo[] properties = t.GetProperties();
			
			foreach (PropertyInfo property in properties)
			{
				Console.WriteLine(property.PropertyType +" "+ property.Name);
			}

			MethodInfo[] methods = t.GetMethods();
			foreach(MethodInfo method in methods)
			{
                Console.WriteLine(method.Name); 
				Console.WriteLine(method.ReturnType);

            }
		}
	}
	public class Customer
	{
		public Customer(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public int Id { get; set; }
		public string Name { get; set; }

	}
}
using System;
using Microsoft.Win32;

namespace Version_.NET_Fraemwork
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Программа для проверки наличия установленой версии .NET Framework");
			Console.WriteLine();
			NetUpdateHistory_1 a = new NetUpdateHistory_1();
			Console.WriteLine();
			NetUpdateHistory_2 b = new NetUpdateHistory_2();
			Console.WriteLine();
			Console.Write("Press any key to continue . . .");
			Console.ReadKey(true);
		}
	}
}
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CLI.Search
{
	class Search
	{
		static void Main(string[] args)
		{
			Console.Write("Welcome to CLI.Search!\n");
			Console.Write("Please select a search engine:\n\n");
			Console.Write("  a. Google\n");
			Console.Write("  b. Yahoo\n");
			Console.Write("  c. Bing\n");
			Console.Write("  d. Ask\n");
			Console.Write("  e. Wikipedia\n");
			Console.Write("  f. YouTube\n\n");
			Console.Write("> ");
			
			for (;true;)
			{
				string strCmd = Console.ReadLine();
				string strQuery = string.Empty;
				
				if (strCmd == "a")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://google.com/search?q=" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else if (strCmd == "b")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://search.yahoo.com/search;_ylt=AqmY8_Y02gfGb3ueo.NDyRibvZx4?p=" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else if (strCmd == "c")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://bing.com/search?q=" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else if (strCmd == "d")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://ask.com/web?q=" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else if (strCmd == "e")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://wikipedia.org/wiki/" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else if (strCmd == "f")
				{
					Console.Write("Please enter your search query:\n");
					Console.Write("> ");
					
					strQuery = Console.ReadLine();
					
					Process.Start("http://youtube.com/results?search_query=" + strQuery);
					
					Console.Write("Would you like to restart? Y/N\n");
					Console.Write("> ");
					
					ConsoleKeyInfo keyYN = Console.ReadKey();
					
					if (keyYN.Key == ConsoleKey.Y)
					{
						Application.Restart();
					}
					
					if (keyYN.Key == ConsoleKey.N)
					{
						Console.Write("Restart ignored.\n");
						Console.Write("> ");
					}
				}
				
				else
				{
					Console.Write("ERROR: Invalid input.\n");
					Console.Write("> ");
				}
			}
		}
	}
}
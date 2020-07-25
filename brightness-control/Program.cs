using System;
using brightness_lib;

namespace brightness_control
{
	class Program
	{
        private static string version = "1.0.0";

		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("brightness-control: you need to choose command, use 'brightness-control.exe help' to see all available commands");
			}
			else if (args.Length == 1)
			{
                int curBr = Controller.Get(), newBr;
                switch (args[0])
                {
                    case "up":
                        newBr = (int)(5 * (Math.Round(((double)curBr + 5) / 5)));
                        if (newBr > 100) newBr = 100;
                        Controller.Set(newBr);
                        break;
                    case "down":
                        newBr = (int)(5 * (Math.Round(((double)curBr - 5) / 5)));
                        if (newBr < 0) newBr = 0;
                        Controller.Set(newBr);
                        break;
                    case "get":
                        Console.WriteLine("brightness-control: current brightness is " + curBr);
                        break;
                    case "help":
                        Console.WriteLine("brightness-control available commands: ");
                        Console.WriteLine("\tup\t- increase brightness (+5%)");
                        Console.WriteLine("\tdown\t - decrease brightness (-5%)");
                        Console.WriteLine("\tget\t - show current brightness");
                        Console.WriteLine("\thelp\t - show available commands");
                        Console.WriteLine("\tversion\t - show app version");
                        break;
                    case "version":
                        Console.WriteLine("brightness-control v" + version);
                        break;
                    default:
                        Console.WriteLine("brightness-control: no such command, use 'brightness-control.exe help' to see all available commands");
                        break;
                }
            }
			else
			{
				Console.WriteLine("brightness-control: you need to choose only one option, use 'brightness-control.exe help' to see all available options");
			}
		}
    }
}

using brightness_lib;
using System;
using System.Diagnostics;

namespace brightness_down
{
	class Program
	{
		static void Main(string[] args)
		{
            IntPtr h = Process.GetCurrentProcess().MainWindowHandle;
            Controller.ShowWindow(h, 0);

            int newBr = (int)(5 * (Math.Round(((double)Controller.Get() - 5) / 5)));
            if (newBr > 100) newBr = 100;
            Controller.Set(newBr);
        }
    }
}

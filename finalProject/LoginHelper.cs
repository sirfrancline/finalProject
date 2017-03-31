using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public static class LoginHelper
    {

        public static string GetPassword()
        {
            var pwd =string.Empty;
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
                    pwd =     pwd.Substring(0,pwd.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    pwd += (i.KeyChar);
                    Console.Write("*");
                }
            }
            return pwd;
        }
    }
}

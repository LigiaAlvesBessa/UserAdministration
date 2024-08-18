using System;
using System.Collections.Generic;

namespace Utility
{
    public class RSGymPTUtility
    {
        public static void SetUnicodeConsole()
        {

            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Console.WriteLine("á Á à À ã Ã â Â ç Ç º ª");

        }

        public static void WriteTitle(string title)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitleAdmin(string title)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitleAdminUserName(string title)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(title.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitlePowerUser(string title)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitlePowerUserUserName(string title)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(title.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitleSimpleUser(string title)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(title.ToUpper());
            Console.WriteLine(new string('-', 60));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteTitleSimpleUserUserName(string title)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public static void WriteMessage(string message, string beginMessage = "", string endMessage = "")
        {

            Console.Write($"{beginMessage}{message}{endMessage}");


        }

        public static void PauseConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\n\nPrime qualquer tecla para continuares.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }




        public static void TerminateConsole()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\n\n\nPrime qualquer tecla para terminares.");
            Console.ForegroundColor = ConsoleColor.White;
            //Environment.Exit(0);
            Console.ReadKey();
            Console.Clear();

        }

        public static void ListData(List<string> list)
        {

            foreach (string item in list)
            {
                RSGymPTUtility.WriteMessage($"{item}", "\n", "");
            }
            RSGymPTUtility.WriteMessage("> ", "\n\n", "");

        }


    }
}

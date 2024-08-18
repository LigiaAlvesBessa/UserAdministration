using System;
using System.Collections.Generic;
using System.Linq;
using UserAdministration.Interfaces;
using Utility;

namespace UserAdministration.Classes
{
    internal class Login : ILogin
    {

        #region Properties

        public string UserName { get; set; }
        public string Password { get; set; }
        public int maxAttempts { get; set; } = 3;

        #endregion

        
        

        #region Methods

        public string GetUserName()
        {

            RSGymPTUtility.WriteMessage("Username: ");
            return Console.ReadLine();

        }

        public string GetPassWord()
        {

            RSGymPTUtility.WriteMessage("Password: ");
            return Console.ReadLine();

        }

        public string ReadPassWord()
        {

            GetPassWord();

            string passWord = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {

                    passWord += key.KeyChar;
                    RSGymPTUtility.WriteMessage("*");

                }
                else if (key.Key == ConsoleKey.Backspace && passWord.Length > 0)
                {
                    passWord = passWord.Substring(0, passWord.Length - 1);
                    RSGymPTUtility.WriteMessage("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return passWord;

        }

        public bool ValidationLogin(string userName, string passWord)
        {

            return UserName == userName && Password == passWord || userName== "admin" && passWord== "admin";

        }

        public User AttempLogin(List<User> list)
        {
            
            try
            {
                Console.Clear();
                RSGymPTUtility.WriteTitle("Login");

                string userName = GetUserName();
                string password = GetPassWord();

                User user = list.FirstOrDefault(u => u.UserName == userName && u.Password == password);
                
                if (user != null) 
                {

                    RSGymPTUtility.WriteMessage($"Login successful! Welcome, {user.UserName}.");
                    RSGymPTUtility.PauseConsole();
                    return user;

                }
                else
                {
                    RSGymPTUtility.WriteMessage("Login failed. Please check your login details.");
                    RSGymPTUtility.PauseConsole();
                    return null;
                }

            }
            catch (Exception ex)
            {

                RSGymPTUtility.WriteMessage($"Error: {ex.Message}");
                RSGymPTUtility.PauseConsole();
                return null;

            }

        }

        #endregion

    }
}

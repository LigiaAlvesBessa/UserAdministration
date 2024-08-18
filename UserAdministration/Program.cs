using System;
using System.Collections.Generic;
using UserAdministration.Classes;
using Utility;

namespace UserAdministration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RSGymPTUtility.SetUnicodeConsole();

            List<User> listUser = new List<User>();

            List<string> menuLogin = new List<string>()
            {
                "1. Login",
                "2. Exit"
            };

            List<string> menuAdmin = new List<string>()
            {
                "1. Create",
                "2. List",
                "3. Search by name",
                "4. Search by Id",
                "5. Edit",
                "6. Logout"
            };

            List<string> menuEditUser = new List<string>()
            {
                "0. Exit Menu Edit User",
                "1. Edit UserType",
                "2. Edit Email",
                "3. Edit Phone Number",
                "4. Edit Birthday",
                "5. Edit Adress",
                "6. Edit Zip Code",
                "7. Edit City",
                "8. Edit Name",
                "9. Edit Password"
 
            };

            List<string> menuPowerUser = new List<string>()
            {
                "1. Search by name",
                "2. List User",
                "3. Logout"
            };

            List<string> menuSimpleUser = new List<string>()
            {
                "1. List User",
                "2. Logout"
            };

            User userAdmin = new User("Admin", Enums.EnumUserType.Admin, "admin@rsgym.pt", "939446411", DateTime.MinValue, "Rua teste 234", "4590-463", "Paços de Ferreira", "admin", "admin");
            User userPowerUser = new User("PowerUser", Enums.EnumUserType.PowerUser, "poweruser@rsgym.pt", "939446411", DateTime.MinValue, "Rua teste 245", "4590-463", "Paços de Ferreira", "poweruser", "poweruser");
            User userSimpleUser = new User("SimpleUser", Enums.EnumUserType.SimpleUser, "simpleuser@rsgym.pt", "939446411", DateTime.MinValue, "Rua teste 485", "4590-463", "Paços de Ferreira", "simpleuser", "simpleuser");
            User user = new User();

            listUser.Add(userAdmin);
            listUser.Add(userPowerUser);
            listUser.Add(userSimpleUser);
            listUser.Add(user);

            Login login = new Login();
            AdminUser adminUser = new AdminUser();
            PowerUser powerUser = new PowerUser();
            SimpleUser simpleUser = new SimpleUser();

            while (true)
            {
                try
                {

                    Console.Clear();
                    RSGymPTUtility.ListData(menuLogin);
                    string optionMenu = Console.ReadLine();

                    switch (optionMenu)
                    {

                        case "1":

                            User loggedInUser = login.AttempLogin(listUser);

                            if (loggedInUser != null)
                            {
                                switch (loggedInUser.UserType)
                                {
                                    case Enums.EnumUserType.Admin:

                                        while (true)
                                        {
                                            try
                                            {
                                                Console.Clear();

                                                RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                RSGymPTUtility.WriteTitleAdmin("Menu");

                                                RSGymPTUtility.ListData(menuAdmin);

                                                string optionMenuAdmin = Console.ReadLine();

                                                switch (optionMenuAdmin)
                                                {
                                                    case "1":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                        adminUser.Create(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenu;
                                                    case "2":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                        adminUser.DetailUser(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenu;
                                                    case "3":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                        adminUser.SearchUser(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenu;
                                                    case "4":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                        adminUser.SearchById(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenu;
                                                    case "5":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                        bool exitEditMenu = false;

                                                        while (!exitEditMenu)
                                                        {

                                                            try
                                                            {

                                                                Console.Clear();

                                                                RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                RSGymPTUtility.WriteTitleAdmin("Menu Edit User");
                                                                RSGymPTUtility.ListData(menuEditUser);

                                                                string optionMenuEditUser = Console.ReadLine();

                                                                switch (optionMenuEditUser)
                                                                {
                                                                    case "1":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditUserType(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "2":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditEmail(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "3":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditPhoneNumber(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "4":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditBirthday(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "5":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditAddress(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "6":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditZipCode(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "7":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditCity(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "8":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditName(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "9":

                                                                        Console.Clear();

                                                                        RSGymPTUtility.WriteTitleAdminUserName($"Username: {loggedInUser.UserName}");

                                                                        adminUser.EditPassword(listUser);

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;

                                                                    case "0":

                                                                        exitEditMenu = true;

                                                                        RSGymPTUtility.PauseConsole();

                                                                        break;
                                                                }

                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                RSGymPTUtility.WriteMessage($"Error: {ex.Message}", "\n", "");
                                                            }

                                                            goto ContinueMenu;

                                                        }

                                                        goto ContinueMenu;

                                                    case "6":

                                                        goto EndAdminMenu;

                                                }

                                            }
                                            catch (Exception ex)
                                            {
                                                RSGymPTUtility.WriteMessage($"Error: {ex.Message}", "\n", "");
                                            }
                                            break;

                                        EndAdminMenu: break;

                                        ContinueMenu: continue;


                                        }

                                        break;

                                    case Enums.EnumUserType.PowerUser:

                                        while (true)
                                        {
                                            try
                                            {
                                                Console.Clear();

                                                RSGymPTUtility.WriteTitlePowerUserUserName($"Username: {loggedInUser.UserName}");

                                                RSGymPTUtility.WriteTitlePowerUser("Menu");
                                                RSGymPTUtility.ListData(menuPowerUser);

                                                string optionMenuPowerUser = Console.ReadLine();

                                                switch (optionMenuPowerUser)
                                                {
                                                    case "1":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitlePowerUserUserName($"Username: {loggedInUser.UserName}");

                                                        powerUser.SearchUser(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenuPowerUser;
                                                    case "2":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitlePowerUserUserName($"Username: {loggedInUser.UserName}");

                                                        powerUser.DetailUser(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenuPowerUser;

                                                    case "3":

                                                        goto EndPowerUser;
                                                }

                                            }
                                            catch
                                            {
                                                RSGymPTUtility.WriteMessage("Wrong option! Please enter a valid menu option.", "\n", "");
                                            }

                                        EndPowerUser: break;

                                        ContinueMenuPowerUser: continue;

                                        }

                                        break;

                                    case Enums.EnumUserType.SimpleUser:

                                        while (true)
                                        {
                                            try
                                            {
                                                Console.Clear();

                                                RSGymPTUtility.WriteTitleSimpleUserUserName($"Username: {loggedInUser.UserName}");

                                                RSGymPTUtility.WriteTitleSimpleUser("Menu");
                                                RSGymPTUtility.ListData(menuSimpleUser);

                                                string optionSimpleUser = Console.ReadLine();

                                                switch (optionSimpleUser)
                                                {
                                                    case "1":

                                                        Console.Clear();

                                                        RSGymPTUtility.WriteTitleSimpleUserUserName($"Username: {loggedInUser.UserName}");

                                                        simpleUser.DetailUser(listUser);

                                                        RSGymPTUtility.PauseConsole();

                                                        goto ContinueMenuSimpleUser;

                                                    case "2":

                                                        goto EndSimpleUser;
                                                }
                                            }
                                            catch
                                            {
                                                RSGymPTUtility.WriteMessage("Wrong option! Please enter a valid menu option.", "\n", "");
                                            }

                                        EndSimpleUser: break;

                                        ContinueMenuSimpleUser: continue;
                                        }

                                        break;
                                }
                            }

                            break;

                        case "2":

                            Console.Clear();
                            RSGymPTUtility.TerminateConsole();
                            return;

                    }

                }
                catch (Exception ex)
                {
                    RSGymPTUtility.WriteMessage($"Error: {ex.Message}", "\n", "");
                }

            }

            

        }
    }
}

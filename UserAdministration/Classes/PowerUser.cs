using System;
using System.Collections.Generic;
using UserAdministration.Interfaces;
using Utility;

namespace UserAdministration.Classes
{
    internal class PowerUser : SimpleUser, IPowerUser
    {

        #region Methods

        public void SearchUser(List<User> list)
        {

            string searchName;

            Console.Clear();
            RSGymPTUtility.WriteTitle("Search User");

            RSGymPTUtility.WriteMessage("Search by name: ");
            searchName = Console.ReadLine();

            User user = list.Find(u => u.Name == searchName);
            if (user != null)
            {
                RSGymPTUtility.WriteMessage($"User Found:\nUser Id: {user.UserId}\nName: {user.Name}\nUser Type: {user.UserType}\nEmail: {user.Email}\nPhone Number: {user.PhoneNumber}\nBirthday: {user.Birthday}\nAdress: {user.Address}\nZip Code: {user.ZipCode}\nCity: {user.City}", "\n", "\n\n");
            }
            else
            {
                RSGymPTUtility.WriteMessage("User not found!", "\n", "\n\n");
            }

        }

        #endregion

    }
}

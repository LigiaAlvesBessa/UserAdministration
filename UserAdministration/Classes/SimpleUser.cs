using System.Collections.Generic;
using UserAdministration.Interfaces;
using Utility;

namespace UserAdministration.Classes
{
    internal class SimpleUser : User, ISimpleUser
    {


        #region Methods

        public void DetailUser(List<User> list)
        {

            foreach (User item in list)
            {

                RSGymPTUtility.WriteMessage($"UserId: {item.UserId}\nName: {item.Name}\nUser Type: {item.UserType}\nEmail: {item.Email}\nPhone Number: {item.PhoneNumber}\nBirthday: {item.Birthday}\nAdress: {item.Address}\nZip Code: {item.ZipCode}\nCity: {item.City}", "\n", "\n\n");

            }

        }

        #endregion

    }
}

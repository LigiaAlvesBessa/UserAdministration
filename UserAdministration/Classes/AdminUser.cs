using System;
using System.Collections.Generic;
using UserAdministration.Interfaces;
using Utility;

namespace UserAdministration.Classes
{
    internal class AdminUser : PowerUser, IAdminUser
    {

        #region Methods

        public void Create(List<User> list)
        {

            string name, email, phoneNumber, address, zipCode, city, userName, password;
            Enums.EnumUserType userType;
            DateTime birthday;

            Console.Clear();
            RSGymPTUtility.WriteTitle("Create User");

            name = GetName();
            userType = GetUserType();
            email = GetEmail();
            phoneNumber = GetPhoneNumber();
            birthday = GetBirthday();
            address = GetAddress();
            zipCode = GetZipCode();
            city = GetCity();
            userName = GetUserName();
            password = GetPassword();


            User user = new User(name, userType, email, phoneNumber, birthday, address, zipCode, city, userName, password);

            SaveUser(list, user);

        }

        private string GetName()
        {

            RSGymPTUtility.WriteMessage("Name: ", "\n", "");
            return Console.ReadLine();
        }

        private Enums.EnumUserType GetUserType()
        {
            Enums.EnumUserType userType;
            string entry01;

            while (true)
            {
                RSGymPTUtility.WriteMessage("User Type: ", "\n", "");
                entry01 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entry01))
                {
                    RSGymPTUtility.WriteMessage("User type cannot be empty. Please enter a valid user type.", "\n", "\n\n");
                    continue;
                }

                if (Enum.TryParse(entry01, true, out userType))
                {
                    return userType;
                }

                RSGymPTUtility.WriteMessage("Invalid input. Please enter a valid user type.", "\n", "\n\n");
            }
        }

        private string GetEmail()
        {

            RSGymPTUtility.WriteMessage("Email: ", "\n", "");
            return Console.ReadLine();

        }

        private string GetPhoneNumber()
        {

            RSGymPTUtility.WriteMessage("Phone Number: ", "\n", "");
            return Console.ReadLine();

        }

        private DateTime GetBirthday()
        {

            DateTime birthday = default;
            bool validEntry = false;
            string entry01;

            RSGymPTUtility.WriteMessage("Birthday (dd/MM/yyyy): ", "\n", "");

            while (!validEntry)
            {
                entry01 = Console.ReadLine();

                if (DateTime.TryParseExact(entry01, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthday))
                {

                    validEntry = true;

                }
                else
                {

                    RSGymPTUtility.WriteMessage("Please enter a valid date of birth (dd/MM/yyyy)!", "\n", "\n\n");
                    RSGymPTUtility.WriteMessage("Birthday (dd/MM/yyyy): ", "\n", "");

                }
            }

            return birthday;

        }

        private string GetAddress()
        {

            RSGymPTUtility.WriteMessage("Address: ", "\n", "");
            return Console.ReadLine();

        }

        private string GetZipCode()
        {

            RSGymPTUtility.WriteMessage("Zip Code: ", "\n", "");
            return Console.ReadLine();

        }

        private string GetCity()
        {

            RSGymPTUtility.WriteMessage("City: ", "\n", "");
            return Console.ReadLine();

        }

        private string GetUserName()
        {
            RSGymPTUtility.WriteMessage("UserName: ", "\n", "");
            return Console.ReadLine();
        }

        private string GetPassword()
        {
            RSGymPTUtility.WriteMessage("Password: ", "\n", "");
            return Console.ReadLine();
        }

        private User SaveUser(List<User> list, User user)
        {

            if(CheckNulls(user))
            {
                return null;
            }

            try
            {
                list.Add(user);
                RSGymPTUtility.WriteMessage("User created successfully!", "\n", "\n\n");
                return user;
            }
            catch (Exception ex)
            {
                RSGymPTUtility.WriteMessage($"Error: Failed to save user. {ex.Message}", "\n", "\n\n");
                return null;
            }

        }

        private bool CheckNulls(User user)
        {
            bool hasErrors = false;

            if (string.IsNullOrEmpty(user.Name))
            {
                RSGymPTUtility.WriteMessage("Error: Name is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.Email))
            {
                RSGymPTUtility.WriteMessage("Error: Email is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                RSGymPTUtility.WriteMessage("Error: Phone Number is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (user.UserType == default(Enums.EnumUserType))
            {
                RSGymPTUtility.WriteMessage("Error: User Type is default.", "\n", "\n\n");
                hasErrors = true;
            }

            if (user.Birthday == default(DateTime))
            {
                RSGymPTUtility.WriteMessage("Error: Birthday is default.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.Address))
            {
                RSGymPTUtility.WriteMessage("Error: Address is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.ZipCode))
            {
                RSGymPTUtility.WriteMessage("Error: Zip Code is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.City))
            {
                RSGymPTUtility.WriteMessage("Error: City is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.UserName))
            {
                RSGymPTUtility.WriteMessage("Error: UserName is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                RSGymPTUtility.WriteMessage("Error: Password is empty.", "\n", "\n\n");
                hasErrors = true;
            }

            return hasErrors;

        }

        public User SearchById(List<User> list)
        {
            int searchId;

            Console.Clear();
            RSGymPTUtility.WriteTitle("Search User");

            RSGymPTUtility.WriteMessage("Search by id: ", "\n", "\n\n");
            searchId = Convert.ToInt32(Console.ReadLine());

            User user = list.Find(u => u.UserId == searchId);
            if (user != null)
            {
                RSGymPTUtility.WriteMessage($"User Found:\nUser Id: {user.UserId}\nName: {user.Name}\nUser Type: {user.UserType}\nEmail: {user.Email}\nPhone Number: {user.PhoneNumber}\nBirthday: {user.Birthday}\nAdress: {user.Address}\nZip Code: {user.ZipCode}\nCity: {user.City}", "\n", "\n\n");
                return user;
            }
            else
            {
                RSGymPTUtility.WriteMessage("User not found!", "\n", "\n\n");
                return null;
            }
        }


        public void EditName(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string name;

            name = GetName();

            user.Name = name;

            RSGymPTUtility.WriteMessage("User Type details updated successfully.", "\n", "\n\n");

        }

        public void EditUserType(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            Enums.EnumUserType userType;

            userType = GetUserType();

            user.UserType = userType;

            RSGymPTUtility.WriteMessage("User Type details updated successfully.", "\n", "\n\n");

        }

        public void EditEmail(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string email;

            email = GetEmail();

            user.Email = email;

            RSGymPTUtility.WriteMessage("User email details updated successfully.", "\n", "\n\n");

        }

        public void EditPhoneNumber(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string phoneNumber;

            phoneNumber = GetPhoneNumber();

            user.PhoneNumber = phoneNumber;

            RSGymPTUtility.WriteMessage("User phone number details updated successfully.", "\n", "\n\n");

        }

        public void EditBirthday(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            DateTime birthday;

            birthday = GetBirthday();

            user.Birthday = birthday;

            RSGymPTUtility.WriteMessage("User birthday details updated successfully.", "\n", "\n\n");

        }

        public void EditAddress(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string address;

            address = GetAddress();

            user.Address = address;

            RSGymPTUtility.WriteMessage("User address details updated successfully.", "\n", "\n\n");

        }

        public void EditZipCode(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string zipCode;

            zipCode = GetZipCode();

            user.ZipCode = zipCode;

            RSGymPTUtility.WriteMessage("User zip code details updated successfully.", "\n", "\n\n");

        }

        public void EditCity(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string city;

            city = GetCity();

            user.City = city;

            RSGymPTUtility.WriteMessage("User city details updated successfully.", "\n", "\n\n");

        }

        public void EditPassword(List<User> list)
        {

            User user = SearchById(list);

            if (user == null)
            {

                RSGymPTUtility.WriteMessage("Cannot edit user as the user was not found.", "\n", "\n\n");
                return;

            }

            string password;

            password = GetPassword();

            user.Password = password;

            RSGymPTUtility.WriteMessage("User city details updated successfully.", "\n", "\n\n");

        }

    }

    #endregion

}


using System;
using UserAdministration.Interfaces;

namespace UserAdministration.Classes
{
    internal class User : IUser, ILogin
    {

        #region Properties

        public static int NextId { get; set; } = 1;
        public int UserId { get; set; }
        public string Name { get; set; }
        public Enums.EnumUserType UserType { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        #endregion

        #region Construtors

        internal User() 
        {

            UserId = 0;
            Name = string.Empty;
            UserType = default;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Birthday = default;
            Address = string.Empty;
            City = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;

        }

        internal User(string name, Enums.EnumUserType userType, string email, string phoneNumber, DateTime birthday, string address, string zipCode, string city, string userName, string password)
        {

            UserId = NextId++;
            Name = name;
            UserType = userType;
            Email = email;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Address = address;
            ZipCode = zipCode;
            City = city;
            UserName = userName;
            Password = password;

        }

        #endregion

    }
}

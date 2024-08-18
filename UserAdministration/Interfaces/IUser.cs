using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Classes;
using static UserAdministration.Enums;

namespace UserAdministration.Interfaces
{
    internal interface IUser
    {

        #region Properties

        int UserId { get; }
        string Name { get; }
        EnumUserType UserType { get; }
        string Email { get; }
        string PhoneNumber { get; }
        DateTime Birthday { get; }
        string Address {  get; }
        string ZipCode { get; }
        string City { get; }

        #endregion

    }
}

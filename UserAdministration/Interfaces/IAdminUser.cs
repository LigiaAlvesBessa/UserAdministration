using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Classes;

namespace UserAdministration.Interfaces
{
    internal interface IAdminUser : IUser, ISimpleUser, IPowerUser
    {

        #region Methods

        void Create(List<User> list);

        User SearchById(List<User> list);

        void EditUserType(List<User> list);

        void EditEmail(List<User> list);

        void EditPhoneNumber(List<User> list);

        void EditBirthday(List<User> list);

        void EditAddress(List<User> list);

        void EditZipCode(List<User> list);

        void EditCity(List<User> list);


        #endregion

    }
}

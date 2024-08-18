using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UserAdministration.Enums;
using UserAdministration.Classes;

namespace UserAdministration.Interfaces
{
    internal interface ISimpleUser : IUser
    {

        #region Methods

        void DetailUser(List<User> list);

        #endregion

    }
}

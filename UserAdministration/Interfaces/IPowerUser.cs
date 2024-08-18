using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAdministration.Classes;

namespace UserAdministration.Interfaces
{
    internal interface IPowerUser : IUser, ISimpleUser
    {

        #region Methods

        void SearchUser(List<User> list);

        #endregion

    }
}

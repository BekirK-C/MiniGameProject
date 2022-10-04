using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Abstract
{
    public interface IUserManager
    {
        void Login(User user);
        void UpdateUserInfo(User user);
        void DeleteUser(User user);
    }
}

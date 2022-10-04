using GameBackendMiniProject.Abstract;
using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Concrete
{
    public class UserManager : IUserManager
    {
        ICheckUserManager _checkUserManager;
        public UserManager(ICheckUserManager checkUserManager)
        {
            _checkUserManager = checkUserManager;
        }
        public void DeleteUser(User user)
        {
            Console.WriteLine(user.FirstName + " is deleted.");
        }

        public void Login(User user)
        {
            if (_checkUserManager.CheckIfRealPerson(user))
            {
                Console.WriteLine(user.FirstName + " is Login.");
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }
        }

        public void UpdateUserInfo(User user)
        {
            Console.WriteLine(user.FirstName + "'s Infos are Updated.");
        }
    }
}

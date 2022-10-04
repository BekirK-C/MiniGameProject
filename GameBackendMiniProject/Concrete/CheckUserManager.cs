using GameBackendMiniProject.Abstract;
using GameBackendMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Concrete
{
    public class CheckUserManager : ICheckUserManager
    {
        public bool CheckIfRealPerson(User user)
        {
            return true;
        }
    }
}

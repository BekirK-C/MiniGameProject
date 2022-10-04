using GameBackendMiniProject.Entities;

namespace GameBackendMiniProject.Abstract
{
    public interface ICheckUserManager
    {
        bool CheckIfRealPerson(User user);
    }
}
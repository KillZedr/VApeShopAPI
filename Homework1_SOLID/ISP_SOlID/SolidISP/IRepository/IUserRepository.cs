using Domain;

namespace IRepository
{
    public interface IUserRepository
    {

        // user-only interface
        void AddInBasket();
        
        void UpdateUser();
        void DeleteUser();
        List<User> GetAllUsers();
        void DeliteFromBasket();

    }
}

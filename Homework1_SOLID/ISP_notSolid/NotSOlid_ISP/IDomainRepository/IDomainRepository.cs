using domain;

namespace IDomainRepository
{
    public interface IDomainRepository
    {

        // a universal interface for all classes that violates the principle of interface separation
        void AddInBasket();
        void VisitorRegistrationInUser();
        void VisitorAuthorizationInUser();
        void UpdateUser();
        void DeleteUser();
        List<User> GetAllUsers();
        void DeliteFromBasket();

    }
}
